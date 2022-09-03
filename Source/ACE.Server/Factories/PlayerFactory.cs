using System;
using System.Collections.Generic;
using System.Linq;

using log4net;

using ACE.Database;
using ACE.DatLoader;
using ACE.DatLoader.FileTypes;
using ACE.Entity;
using ACE.Entity.Enum;
using ACE.Entity.Enum.Properties;
using ACE.Entity.Models;
using ACE.Server.WorldObjects;
using ACE.Server.Managers;
using ACE.Server.Entity;
using ACE.Database.Models.Shard;

namespace ACE.Server.Factories
{
    public static class PlayerFactory
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public enum CreateResult
        {
            Success,
            TooManySkillCreditsUsed,
            InvalidSkillRequested,
            FailedToTrainSkill,
            FailedToSpecializeSkill,
            ClientServerSkillsMismatch
        }

        public static CreateResult Create(CharacterCreateInfo characterCreateInfo, Weenie weenie, ObjectGuid guid, uint accountId, WeenieType weenieType, out Player player)
        {
            var heritageGroup = DatManager.PortalDat.CharGen.HeritageGroups[(uint)characterCreateInfo.Heritage];

            if (weenieType == WeenieType.Admin)
                player = new Admin(weenie, guid, accountId);
            else if (weenieType == WeenieType.Sentinel)
                player = new Sentinel(weenie, guid, accountId);
            else
                player = new Player(weenie, guid, accountId);

            player.SetProperty(PropertyInt.HeritageGroup, (int)characterCreateInfo.Heritage);
            player.SetProperty(PropertyString.HeritageGroup, heritageGroup.Name);
            player.SetProperty(PropertyInt.Gender, (int)characterCreateInfo.Gender);
            player.SetProperty(PropertyString.Sex, characterCreateInfo.Gender == 1 ? "Male" : "Female");

            //player.SetProperty(PropertyDataId.Icon, cgh.IconImage); // I don't believe this is used anywhere in the client, but it might be used by a future custom launcher

            // pull character data from the dat file
            var sex = heritageGroup.Genders[(int)characterCreateInfo.Gender];

            player.SetProperty(PropertyDataId.MotionTable, sex.MotionTable);
            player.SetProperty(PropertyDataId.SoundTable, sex.SoundTable);
            player.SetProperty(PropertyDataId.PhysicsEffectTable, sex.PhysicsTable);
            player.SetProperty(PropertyDataId.Setup, sex.SetupID);
            player.SetProperty(PropertyDataId.PaletteBase, sex.BasePalette);
            player.SetProperty(PropertyDataId.CombatTable, sex.CombatTable);

            // Check the character scale
            if (sex.Scale != 100)
                player.SetProperty(PropertyFloat.DefaultScale, sex.Scale / 100.0f); // Scale is stored as a percentage

            // Get the hair first, because we need to know if you're bald, and that's the name of that tune!
            var hairstyle = sex.HairStyleList[(int)characterCreateInfo.Appearance.HairStyle];

            // Olthoi and Gear Knights have a "Body Style" instead of a hair style. These styles have multiple model/texture changes, instead of a single head/hairstyle.
            // Storing this value allows us to send the proper appearance ObjDesc
            if (hairstyle.ObjDesc.AnimPartChanges.Count > 1)
                player.SetProperty(PropertyInt.Hairstyle, (int)characterCreateInfo.Appearance.HairStyle);

            // Certain races (Undead, Tumeroks, Others?) have multiple body styles available. This is controlled via the "hair style".
            if (hairstyle.AlternateSetup > 0)
                player.SetProperty(PropertyDataId.Setup, hairstyle.AlternateSetup);

            player.SetProperty(PropertyDataId.EyesTexture, sex.GetEyeTexture(characterCreateInfo.Appearance.Eyes, hairstyle.Bald));
            player.SetProperty(PropertyDataId.DefaultEyesTexture, sex.GetDefaultEyeTexture(characterCreateInfo.Appearance.Eyes, hairstyle.Bald));
            player.SetProperty(PropertyDataId.NoseTexture, sex.GetNoseTexture(characterCreateInfo.Appearance.Nose));
            player.SetProperty(PropertyDataId.DefaultNoseTexture, sex.GetDefaultNoseTexture(characterCreateInfo.Appearance.Nose));
            player.SetProperty(PropertyDataId.MouthTexture, sex.GetMouthTexture(characterCreateInfo.Appearance.Mouth));
            player.SetProperty(PropertyDataId.DefaultMouthTexture, sex.GetDefaultMouthTexture(characterCreateInfo.Appearance.Mouth));
            player.Character.HairTexture = sex.GetHairTexture(characterCreateInfo.Appearance.HairStyle) ?? 0;
            player.Character.DefaultHairTexture = sex.GetDefaultHairTexture(characterCreateInfo.Appearance.HairStyle) ?? 0;
            // HeadObject can be null if we're dealing with GearKnight or Olthoi
            var headObject = sex.GetHeadObject(characterCreateInfo.Appearance.HairStyle);
            if (headObject != null)
                player.SetProperty(PropertyDataId.HeadObject, (uint)headObject);

            // Skin is stored as PaletteSet (list of Palettes), so we need to read in the set to get the specific palette
            var skinPalSet = DatManager.PortalDat.ReadFromDat<PaletteSet>(sex.SkinPalSet);
            player.SetProperty(PropertyDataId.SkinPalette, skinPalSet.GetPaletteID(characterCreateInfo.Appearance.SkinHue));
            player.SetProperty(PropertyFloat.Shade, characterCreateInfo.Appearance.SkinHue);

            // Hair is stored as PaletteSet (list of Palettes), so we need to read in the set to get the specific palette
            var hairPalSet = DatManager.PortalDat.ReadFromDat<PaletteSet>(sex.HairColorList[(int)characterCreateInfo.Appearance.HairColor]);
            player.SetProperty(PropertyDataId.HairPalette, hairPalSet.GetPaletteID(characterCreateInfo.Appearance.HairHue));

            // Eye Color
            player.SetProperty(PropertyDataId.EyesPalette, sex.EyeColorList[(int)characterCreateInfo.Appearance.EyeColor]);

            // skip over this for olthoi, use the weenie defaults
            if (!player.IsOlthoiPlayer)
            {
                if (characterCreateInfo.Appearance.HeadgearStyle < uint.MaxValue) // No headgear is max UINT
                {
                    var hat = GetClothingObject(sex.GetHeadgearWeenie(characterCreateInfo.Appearance.HeadgearStyle), characterCreateInfo.Appearance.HeadgearColor, characterCreateInfo.Appearance.HeadgearHue);
                    if (hat != null)
                        player.TryEquipObject(hat, hat.ValidLocations ?? 0);
                    else
                        player.TryAddToInventory(CreateIOU(sex.GetHeadgearWeenie(characterCreateInfo.Appearance.HeadgearStyle)));
                }

                var shirt = GetClothingObject(sex.GetShirtWeenie(characterCreateInfo.Appearance.ShirtStyle), characterCreateInfo.Appearance.ShirtColor, characterCreateInfo.Appearance.ShirtHue);
                if (shirt != null)
                    player.TryEquipObject(shirt, shirt.ValidLocations ?? 0);
                else
                    player.TryAddToInventory(CreateIOU(sex.GetShirtWeenie(characterCreateInfo.Appearance.ShirtStyle)));

                var pants = GetClothingObject(sex.GetPantsWeenie(characterCreateInfo.Appearance.PantsStyle), characterCreateInfo.Appearance.PantsColor, characterCreateInfo.Appearance.PantsHue);
                if (pants != null)
                    player.TryEquipObject(pants, pants.ValidLocations ?? 0);
                else
                    player.TryAddToInventory(CreateIOU(sex.GetPantsWeenie(characterCreateInfo.Appearance.PantsStyle)));

                var shoes = GetClothingObject(sex.GetFootwearWeenie(characterCreateInfo.Appearance.FootwearStyle), characterCreateInfo.Appearance.FootwearColor, characterCreateInfo.Appearance.FootwearHue);
                if (shoes != null)
                    player.TryEquipObject(shoes, shoes.ValidLocations ?? 0);
                else
                    player.TryAddToInventory(CreateIOU(sex.GetFootwearWeenie(characterCreateInfo.Appearance.FootwearStyle)));

                string templateName = heritageGroup.Templates[characterCreateInfo.TemplateOption].Name;
                player.SetProperty(PropertyString.Template, templateName);

                player.AddTitle(heritageGroup.Templates[characterCreateInfo.TemplateOption].Title, true);

                // attributes
                var result = ValidateAttributeCredits(characterCreateInfo, heritageGroup.AttributeCredits);

                if (result != CreateResult.Success)
                    return result;

                player.Strength.StartingValue = characterCreateInfo.StrengthAbility;
                player.Endurance.StartingValue = characterCreateInfo.EnduranceAbility;
                player.Coordination.StartingValue = characterCreateInfo.CoordinationAbility;
                player.Quickness.StartingValue = characterCreateInfo.QuicknessAbility;
                player.Focus.StartingValue = characterCreateInfo.FocusAbility;
                player.Self.StartingValue = characterCreateInfo.SelfAbility;

                // data we don't care about
                //characterCreateInfo.CharacterSlot;
                //characterCreateInfo.ClassId;

                // characters start with max vitals
                player.Health.Current = player.Health.Base;
                player.Stamina.Current = player.Stamina.Base;
                player.Mana.Current = player.Mana.Base;

                // set initial skill credit amount. 52 for all but "Olthoi", which have 68
                player.SetProperty(PropertyInt.AvailableSkillCredits, (int)heritageGroup.SkillCredits);
                player.SetProperty(PropertyInt.TotalSkillCredits, (int)heritageGroup.SkillCredits);

                if (Common.ConfigManager.Config.Server.WorldRuleset == Common.Ruleset.EoR)
                {
                    if (characterCreateInfo.SkillAdvancementClasses.Count != 55)
                        return CreateResult.ClientServerSkillsMismatch;
                }
                if (Common.ConfigManager.Config.Server.WorldRuleset == Common.Ruleset.CustomDM)
                {
                    if (characterCreateInfo.SkillAdvancementClasses.Count != 49) // Not really 49 but shield skill is id 48 so we get a few empty slots. The client doesn't seem to mind at all.
                        return CreateResult.ClientServerSkillsMismatch;
                }
                else
                {
                    if (characterCreateInfo.SkillAdvancementClasses.Count != 41)
                        return CreateResult.ClientServerSkillsMismatch;
                }

                for (int i = 0; i < characterCreateInfo.SkillAdvancementClasses.Count; i++)
                {
                    var sac = characterCreateInfo.SkillAdvancementClasses[i];

                    if (sac == SkillAdvancementClass.Inactive)
                        continue;

                    if (!DatManager.PortalDat.SkillTable.SkillBaseHash.ContainsKey((uint)i))
                    {
                        log.ErrorFormat("Character {0} tried to create with skill {1} that was not found in Portal dat.", characterCreateInfo.Name, i);
                        return CreateResult.InvalidSkillRequested;
                    }

                    var skill = DatManager.PortalDat.SkillTable.SkillBaseHash[(uint)i];

                    var trainedCost = skill.TrainedCost;
                    var specializedCost = skill.UpgradeCostFromTrainedToSpecialized;

                    foreach (var skillGroup in heritageGroup.Skills)
                    {
                        if (skillGroup.SkillNum == i)
                        {
                            trainedCost = skillGroup.NormalCost;
                            specializedCost = skillGroup.PrimaryCost;
                            break;
                        }
                    }

                    if (sac == SkillAdvancementClass.Specialized)
                    {
                        if (!player.TrainSkill((Skill)i, trainedCost))
                            return CreateResult.FailedToTrainSkill;
                        if (!player.SpecializeSkill((Skill)i, specializedCost))
                            return CreateResult.FailedToSpecializeSkill;
                    }
                    else if (sac == SkillAdvancementClass.Trained)
                    {
                        if (!player.TrainSkill((Skill)i, trainedCost, true))
                            return CreateResult.FailedToTrainSkill;
                    }
                    else if (sac == SkillAdvancementClass.Untrained)
                        player.UntrainSkill((Skill)i, 0);
                }

                bool isDualWieldTrainedOrSpecialized = false;
                if (Common.ConfigManager.Config.Server.WorldRuleset == Common.Ruleset.EoR)
                {
                    isDualWieldTrainedOrSpecialized = player.Skills[Skill.DualWield].AdvancementClass > SkillAdvancementClass.Untrained;

                    // Set Heritage based Melee and Ranged Masteries
                    GetMasteries(player.HeritageGroup, out WeaponType meleeMastery, out WeaponType rangedMastery);

                    player.SetProperty(PropertyInt.MeleeMastery, (int)meleeMastery);
                    player.SetProperty(PropertyInt.RangedMastery, (int)rangedMastery);

                    // Set innate augs
                    SetInnateAugmentations(player);
                }
                else
                {
                    // Quick check to confirm if the player has all their racial skills.
                    foreach (var skillGroup in heritageGroup.Skills)
                    {
                        var skill = player.GetCreatureSkill((Skill)skillGroup.SkillNum);
                        if (skillGroup.PrimaryCost == 0)
                        {
                            if (skill.AdvancementClass != SkillAdvancementClass.Specialized)
                                return CreateResult.FailedToSpecializeSkill;
                        }
                        else if (skillGroup.NormalCost == 0 && skill.AdvancementClass != SkillAdvancementClass.Trained && skill.AdvancementClass != SkillAdvancementClass.Specialized)
                            return CreateResult.FailedToTrainSkill;
                    }
                }

                // grant starter items based on skills
                var starterGearConfig = StarterGearFactory.GetStarterGearConfiguration();
                var grantedWeenies = new List<uint>();

                Container container = null;
                foreach (var skillGear in starterGearConfig.Skills)
                {
                    //var charSkill = player.Skills[(Skill)skillGear.SkillId];
                    if (!player.Skills.TryGetValue((Skill)skillGear.SkillId, out var charSkill))
                        continue;

                    if (charSkill.AdvancementClass == SkillAdvancementClass.Trained || charSkill.AdvancementClass == SkillAdvancementClass.Specialized)
                    {
                        foreach (var item in skillGear.Gear)
                        {
                            if (charSkill.AdvancementClass == SkillAdvancementClass.Trained && item.SpecializedOnly == true)
                                continue;

                            if (grantedWeenies.Contains(item.WeenieId))
                            {
                                var existingItem = player.Inventory.Values.FirstOrDefault(i => i.WeenieClassId == item.WeenieId);
                                if (existingItem == null || (existingItem.MaxStackSize ?? 1) <= 1)
                                    continue;

                                existingItem.SetStackSize(existingItem.StackSize + item.StackSize);
                                continue;
                            }

                            var loot = WorldObjectFactory.CreateNewWorldObject(item.WeenieId);
                            if (loot != null)
                            {
                                if (container == null && loot.WeenieType == WeenieType.Container)
                                    container = (Container)loot;

                                if (loot.StackSize.HasValue && loot.MaxStackSize.HasValue)
                                    loot.SetStackSize((item.StackSize <= loot.MaxStackSize) ? item.StackSize : loot.MaxStackSize);
                            }
                            else
                            {
                                player.TryAddToInventory(CreateIOU(item.WeenieId));
                            }

                            if (loot != null)
                            {
                                bool added = false;
                                if (container != null && loot.WeenieType == WeenieType.SpellComponent) // try to stash spell components on a secondary pack
                                    if (container.TryAddToInventory(loot))
                                        added = true;

                                if (!added)
                                    if (player.TryAddToInventory(loot))
                                        added = true;

                                if (added)
                                    grantedWeenies.Add(item.WeenieId);
                            }

                            if (isDualWieldTrainedOrSpecialized && loot != null)
                            {
                                if (loot.WeenieType == WeenieType.MeleeWeapon)
                                {
                                    var dualloot = WorldObjectFactory.CreateNewWorldObject(item.WeenieId);
                                    if (dualloot != null)
                                    {
                                        player.TryAddToInventory(dualloot);
                                    }
                                    else
                                    {
                                        player.TryAddToInventory(CreateIOU(item.WeenieId));
                                    }
                                }
                            }
                        }

                        var heritageLoot = skillGear.Heritage.FirstOrDefault(i => i.HeritageId == (ushort)characterCreateInfo.Heritage);
                        if (heritageLoot != null)
                        {
                            foreach (var item in heritageLoot.Gear)
                            {
                                if (charSkill.AdvancementClass == SkillAdvancementClass.Trained && item.SpecializedOnly == true)
                                    continue;

                                if (grantedWeenies.Contains(item.WeenieId))
                                {
                                    var existingItem = player.Inventory.Values.FirstOrDefault(i => i.WeenieClassId == item.WeenieId);
                                    if (existingItem == null || (existingItem.MaxStackSize ?? 1) <= 1)
                                        continue;

                                    existingItem.SetStackSize(existingItem.StackSize + item.StackSize);
                                    continue;
                                }

                                var loot = WorldObjectFactory.CreateNewWorldObject(item.WeenieId);
                                if (loot != null)
                                {
                                    if (loot.StackSize.HasValue && loot.MaxStackSize.HasValue)
                                        loot.SetStackSize((item.StackSize <= loot.MaxStackSize) ? item.StackSize : loot.MaxStackSize);
                                }
                                else
                                {
                                    player.TryAddToInventory(CreateIOU(item.WeenieId));
                                }

                                if (loot != null && player.TryAddToInventory(loot))
                                    grantedWeenies.Add(item.WeenieId);

                                if (isDualWieldTrainedOrSpecialized && loot != null)
                                {
                                    if (loot.WeenieType == WeenieType.MeleeWeapon)
                                    {
                                        var dualloot = WorldObjectFactory.CreateNewWorldObject(item.WeenieId);
                                        if (dualloot != null)
                                        {
                                            player.TryAddToInventory(dualloot);
                                        }
                                        else
                                        {
                                            player.TryAddToInventory(CreateIOU(item.WeenieId));
                                        }
                                    }
                                }
                            }
                        }

                        foreach (var spell in skillGear.Spells)
                        {
                            // Olthoi Spitter is a special case
                            if (characterCreateInfo.Heritage == HeritageGroup.OlthoiAcid)
                            {
                                player.AddKnownSpell(spell.SpellId);
                                // Continue to next spell as Olthoi spells do not have the SpecializedOnly field
                                continue;
                            }

                            bool spellAdded = false;
                            if (charSkill.AdvancementClass == SkillAdvancementClass.Trained && spell.SpecializedOnly == false)
                                spellAdded = player.AddKnownSpell(spell.SpellId);
                            else if (charSkill.AdvancementClass == SkillAdvancementClass.Specialized)
                                spellAdded = player.AddKnownSpell(spell.SpellId);

                            if (spellAdded && Common.ConfigManager.Config.Server.WorldRuleset == Common.Ruleset.CustomDM)
                            {
                                // Quality of life: set the entries for the player's /fillcomps
                                Spell spellEntity = new Spell(spell.SpellId);
                                foreach (var componentId in spellEntity.Formula.Components)
                                {
                                    uint amount = 10;
                                    if (SpellFormula.SpellComponentsTable.SpellComponents.TryGetValue(componentId, out var spellComponent))
                                    {
                                        if (spellComponent.Type == (int)SpellComponentsTable.Type.Scarab || spellComponent.Type == (int)SpellComponentsTable.Type.Talisman)
                                            amount = 3;

                                        player.Character.AddFillComponent(Spell.GetComponentWCID(componentId), amount, player.CharacterDatabaseLock, out _);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (player.CharacterTitleId > 0)
                    player.AddTitle((uint)player.CharacterTitleId.Value, true);

                if (player.Biota.PropertiesSpellBook?.Count > 0)
                {
                    var i = 0u;
                    foreach (var spell in player.Biota.PropertiesSpellBook)
                    {
                        player.HandleActionAddSpellFavorite((uint)spell.Key, i++, 0);
                    }
                }
            }

            player.Name = characterCreateInfo.Name;
            player.Character.Name = characterCreateInfo.Name;


            // Index used to determine the starting location
            var startArea = characterCreateInfo.StartArea;

            var starterArea = DatManager.PortalDat.CharGen.StarterAreas[(int)startArea];

            var instantiation = new Position(0xA9B40019, 84, 7.1f, 94, 0, 0, -0.0784591f, 0.996917f); // ultimate fallback.

            if (Common.ConfigManager.Config.Server.WorldRuleset == Common.Ruleset.EoR)
            {
                player.Location = new Position(starterArea.Locations[0].ObjCellID,
                    starterArea.Locations[0].Frame.Origin.X, starterArea.Locations[0].Frame.Origin.Y, starterArea.Locations[0].Frame.Origin.Z,
                    starterArea.Locations[0].Frame.Orientation.X, starterArea.Locations[0].Frame.Orientation.Y, starterArea.Locations[0].Frame.Orientation.Z, starterArea.Locations[0].Frame.Orientation.W);

                var spellFreeRide = new ACE.Database.Models.World.Spell();
                switch (starterArea.Name)
                {
                    case "OlthoiLair": //todo: check this when olthoi play is allowed in ace
                        spellFreeRide = null; // no training area for olthoi, so they start and fall back to same place.
                        instantiation = new Position(player.Location);
                        break;
                    case "Shoushi":
                        spellFreeRide = DatabaseManager.World.GetCachedSpell(3813); // Free Ride to Shoushi
                        break;
                    case "Yaraq":
                        spellFreeRide = DatabaseManager.World.GetCachedSpell(3814); // Free Ride to Yaraq
                        break;
                    case "Sanamar":
                        spellFreeRide = DatabaseManager.World.GetCachedSpell(3535); // Free Ride to Sanamar
                        break;
                    case "Holtburg":
                    default:
                        spellFreeRide = DatabaseManager.World.GetCachedSpell(3815); // Free Ride to Holtburg
                        break;
                }
                if (spellFreeRide != null && spellFreeRide.Name != "")
                    instantiation = new Position(spellFreeRide.PositionObjCellId.Value, spellFreeRide.PositionOriginX.Value, spellFreeRide.PositionOriginY.Value, spellFreeRide.PositionOriginZ.Value, spellFreeRide.PositionAnglesX.Value, spellFreeRide.PositionAnglesY.Value, spellFreeRide.PositionAnglesZ.Value, spellFreeRide.PositionAnglesW.Value);

                player.SetProperty(PropertyBool.RecallsDisabled, true);
            }
            else
            {
                switch (starterArea.Name)
                {
                    case "Shoushi":
                        player.Location = new Position(0xDE51001D, 87.350517f, 114.857246f, 16.004999f, 0, 0, 0.537665f, 0.843159f);
                        break;
                    case "Yaraq":
                        player.Location = new Position(0x7D680012, 56.949219f, 29.860384f, 14.981730f, 0, 0, -0.879578f, 0.475755f);
                        break;
                    case "Holtburg":
                    default: //redirect Sanamar to Holtburg as Sanamar is post-ToD.
                        player.Location = new Position(0xA9B00015, 53.780079f, 105.814995f, 64.005005f, 0, 0, -0.359575f, -0.933116f);
                        break;
                }

                instantiation = new Position(player.Location);
            }

            player.Instantiation = new Position(instantiation);

            if (!player.IsOlthoiPlayer)
            {
                player.Sanctuary = new Position(player.Location);

                if (PropertyManager.GetBool("pk_server").Item)
                    player.SetProperty(PropertyInt.PlayerKillerStatus, (int)PlayerKillerStatus.PK);
                else if (PropertyManager.GetBool("pkl_server").Item)
                    player.SetProperty(PropertyInt.PlayerKillerStatus, (int)PlayerKillerStatus.NPK);

                if ((PropertyManager.GetBool("pk_server").Item || PropertyManager.GetBool("pkl_server").Item) && PropertyManager.GetBool("pk_server_safe_training_academy").Item)
                {
                    player.SetProperty(PropertyFloat.MinimumTimeSincePk, -PropertyManager.GetDouble("pk_new_character_grace_period").Item);
                    player.SetProperty(PropertyInt.PlayerKillerStatus, (int)PlayerKillerStatus.NPK);
                }
            }

            if (player is Sentinel || player is Admin)
            {
                player.Character.IsPlussed = true;
                player.CloakStatus = CloakStatus.Off;
                player.ChannelsAllowed = player.ChannelsActive;
            }

            CharacterCreateSetDefaultCharacterOptions(player);

            return CreateResult.Success;
        }

        private static WorldObject GetClothingObject(uint weenieClassId, uint palette, double shade)
        {
            var weenie = DatabaseManager.World.GetCachedWeenie(weenieClassId);

            if (weenie == null)
                return null;

            var worldObject = (Clothing)WorldObjectFactory.CreateNewWorldObject(weenie);

            worldObject.SetProperties((int)palette, shade);

            //if (shirtCT.ClothingBaseEffects.ContainsKey(sex.SetupID))
            //{
            //    ClothingBaseEffect shirtCBE = shirtCT.ClothingBaseEffects[sex.SetupID];
            //    for (int i = 0; i < shirtCBE.CloObjectEffects.Count; i++)
            //    {
            //        byte partNum = (byte)shirtCBE.CloObjectEffects[i].Index;
            //        shirt.AnimationOverrides.Add(new AnimationOverride()
            //        {
            //            AceObjectId = shirt.AceObjectId,
            //            AnimationId = shirtCBE.CloObjectEffects[i].ModelId,
            //            Index = (byte)shirtCBE.CloObjectEffects[i].Index
            //        });

            //        for (int j = 0; j < shirtCBE.CloObjectEffects[i].CloTextureEffects.Count; j++)
            //        {
            //            shirt.TextureOverrides.Add(new TextureMapOverride()
            //            {
            //                AceObjectId = shirt.AceObjectId,
            //                Index = (byte)shirtCBE.CloObjectEffects[i].Index,
            //                OldId = (ushort)shirtCBE.CloObjectEffects[i].CloTextureEffects[j].OldTexture,
            //                NewId = (ushort)shirtCBE.CloObjectEffects[i].CloTextureEffects[j].NewTexture
            //            });
            //        }
            //    }

            //    // Apply the proper palette(s). Unlike character skin/hair, clothes can have several palette ranges!
            //    if (shirtCT.ClothingSubPalEffects.ContainsKey(appearance.ShirtColor))
            //    {
            //        CloSubPalEffect shirtSubPal = shirtCT.ClothingSubPalEffects[appearance.ShirtColor];
            //        for (int i = 0; i < shirtSubPal.CloSubPalettes.Count; i++)
            //        {
            //            PaletteSet shirtPalSet = PaletteSet.ReadFromDat(shirtSubPal.CloSubPalettes[i].PaletteSet);
            //            ushort shirtPal = (ushort)shirtPalSet.GetPaletteID(appearance.ShirtHue);

            //            if (shirtPal > 0) // shirtPal will be 0 if the palette set is empty/not found
            //            {
            //                for (int j = 0; j < shirtSubPal.CloSubPalettes[i].Ranges.Count; j++)
            //                {
            //                    uint palOffset = shirtSubPal.CloSubPalettes[i].Ranges[j].Offset / 8;
            //                    uint numColors = shirtSubPal.CloSubPalettes[i].Ranges[j].NumColors / 8;
            //                    shirt.PaletteOverrides.Add(new PaletteOverride()
            //                    {
            //                        AceObjectId = shirt.AceObjectId,
            //                        SubPaletteId = shirtPal,
            //                        Offset = (ushort)palOffset,
            //                        Length = (ushort)numColors
            //                    });
            //                }
            //            }
            //        }
            //    }
            //}

            return worldObject;
        }

        /// <summary>
        /// Set Heritage based Melee and Ranged Masteries
        /// </summary>
        private static void GetMasteries(HeritageGroup heritageGroup, out WeaponType meleeMastery, out WeaponType rangedMastery)
        {
            switch (heritageGroup)
            {
                case HeritageGroup.Aluvian:
                    meleeMastery = WeaponType.Dagger;
                    rangedMastery = WeaponType.Bow;
                    break;
                case HeritageGroup.Gharundim:
                    meleeMastery = WeaponType.Staff;
                    rangedMastery = WeaponType.Magic;
                    break;
                case HeritageGroup.Sho:
                    meleeMastery = WeaponType.Unarmed;
                    rangedMastery = WeaponType.Bow;
                    break;
                case HeritageGroup.Viamontian:
                    meleeMastery = WeaponType.Sword;
                    rangedMastery = WeaponType.Crossbow;
                    break;
                case HeritageGroup.Penumbraen:
                case HeritageGroup.Shadowbound:
                    meleeMastery = WeaponType.Unarmed;
                    rangedMastery = WeaponType.Crossbow;
                    break;
                case HeritageGroup.Gearknight:
                    meleeMastery = WeaponType.Mace;
                    rangedMastery = WeaponType.Crossbow;
                    break;
                case HeritageGroup.Tumerok:
                    meleeMastery = WeaponType.Spear;
                    rangedMastery = WeaponType.Thrown;
                    break;
                case HeritageGroup.Undead:
                case HeritageGroup.Lugian:
                    meleeMastery = WeaponType.Axe;
                    rangedMastery = WeaponType.Thrown;
                    break;
                case HeritageGroup.Empyrean:
                    meleeMastery = WeaponType.Sword;
                    rangedMastery = WeaponType.Magic;
                    break;
                default:
                    meleeMastery = WeaponType.Undef;
                    rangedMastery = WeaponType.Undef;
                    break;
            }
        }

        private static void SetInnateAugmentations(Player player)
        {
            switch (player.HeritageGroup)
            {
                case HeritageGroup.Aluvian:
                case HeritageGroup.Gharundim:
                case HeritageGroup.Sho:
                case HeritageGroup.Viamontian:
                    player.AugmentationJackOfAllTrades = 1;
                    break;

                case HeritageGroup.Shadowbound:
                case HeritageGroup.Penumbraen:
                    player.AugmentationCriticalExpertise = 1;
                    break;

                case HeritageGroup.Gearknight:
                    player.AugmentationDamageReduction = 1;
                    break;

                case HeritageGroup.Undead:
                    player.AugmentationCriticalDefense = 1;
                    break;

                case HeritageGroup.Empyrean:
                    player.AugmentationInfusedLifeMagic = 1;
                    break;

                case HeritageGroup.Tumerok:
                    player.AugmentationCriticalPower = 1;
                    break;

                case HeritageGroup.Lugian:
                    player.AugmentationIncreasedCarryingCapacity = 1;
                    break;

                case HeritageGroup.Olthoi:
                case HeritageGroup.OlthoiAcid:
                    break;
            }
        }

        public static WorldObject CreateIOU(uint missingWeenieId)
        {
            var iou = (Book)WorldObjectFactory.CreateNewWorldObject("parchment");

            iou.SetProperties("IOU", "An IOU for a missing database object.", "Sorry about that chief...", "ACEmulator", "prewritten");
            iou.AddPage(uint.MaxValue, "ACEmulator", "prewritten", false, $"{missingWeenieId}\n\nSorry but the database does not have a weenie for weenieClassId #{missingWeenieId} so in lieu of that here is an IOU for that item.", out _);
            iou.Bonded = BondedStatus.Bonded;
            iou.Attuned = AttunedStatus.Attuned;
            iou.IsSellable = false;
            iou.Value = 0;
            iou.EncumbranceVal = 0;

            return iou;
        }

        /// <summary>
        /// Validates character creation attribute info
        /// </summary>
        private static CreateResult ValidateAttributeCredits(CharacterCreateInfo info, uint maxAttributes)
        {
            var attributeValues = new List<uint>()
            {
                info.StrengthAbility,
                info.EnduranceAbility,
                info.CoordinationAbility,
                info.QuicknessAbility,
                info.FocusAbility,
                info.SelfAbility
            };

            uint total = 0;

            foreach (var attributeValue in attributeValues)
            {
                if (attributeValue < 10 || attributeValue > 100)
                    return CreateResult.InvalidSkillRequested;

                total += attributeValue;
            }

            if (total > maxAttributes)
                return CreateResult.TooManySkillCreditsUsed;

            return CreateResult.Success;
        }

        private static void CharacterCreateSetDefaultCharacterOptions(Player player)
        {
            player.SetCharacterOption(CharacterOption.VividTargetingIndicator, true);
            player.SetCharacterOption(CharacterOption.Display3dTooltips, true);
            player.SetCharacterOption(CharacterOption.ShowCoordinatesByTheRadar, true);
            player.SetCharacterOption(CharacterOption.DisplaySpellDurations, true);
            player.SetCharacterOption(CharacterOption.IgnoreFellowshipRequests, true);
            player.SetCharacterOption(CharacterOption.ShareFellowshipExpAndLuminance, true);
            player.SetCharacterOption(CharacterOption.LetOtherPlayersGiveYouItems, true);
            player.SetCharacterOption(CharacterOption.RunAsDefaultMovement, true);
            player.SetCharacterOption(CharacterOption.AutoTarget, true);
            player.SetCharacterOption(CharacterOption.AutoRepeatAttacks, true);
            player.SetCharacterOption(CharacterOption.UseChargeAttack, true);
            player.SetCharacterOption(CharacterOption.LeadMissileTargets, true);
            player.SetCharacterOption(CharacterOption.ListenToAllegianceChat, true);
            player.SetCharacterOption(CharacterOption.ListenToGeneralChat, true);
            player.SetCharacterOption(CharacterOption.ListenToTradeChat, true);
            player.SetCharacterOption(CharacterOption.ListenToLFGChat, true);

            // Not official client defaults, might have been creation defaults however to avoid initial confusion about helm/cloak equipping
            player.SetCharacterOption(CharacterOption.ShowYourHelmOrHeadGear, true);
            player.SetCharacterOption(CharacterOption.ShowYourCloak, true);
        }
    }
}
