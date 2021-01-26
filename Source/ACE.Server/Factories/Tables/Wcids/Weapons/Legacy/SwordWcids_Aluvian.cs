using System;
using System.Collections.Generic;

using ACE.Server.Factories.Entity;
using ACE.Server.Factories.Enum;

namespace ACE.Server.Factories.Tables.Wcids
{
    public static class SwordWcids_Aluvian
    {
        private static ChanceTable<WeenieClassName> T1_Chances;

        private static ChanceTable<WeenieClassName> T1_T2_Chances = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.swordrapier,        0.10f ),
            ( WeenieClassName.swordshort,         0.12f ),
            ( WeenieClassName.swordshortacid,     0.03f ),
            ( WeenieClassName.swordshortelectric, 0.03f ),
            ( WeenieClassName.swordshortfire,     0.03f ),
            ( WeenieClassName.swordshortfrost,    0.03f ),
            ( WeenieClassName.scimitar,           0.10f ),
            ( WeenieClassName.scimitaracid,       0.03f ),
            ( WeenieClassName.scimitarelectric,   0.03f ),
            ( WeenieClassName.scimitarfire,       0.03f ),
            ( WeenieClassName.scimitarfrost,      0.03f ),
            ( WeenieClassName.swordlong,          0.10f ),
            ( WeenieClassName.swordlongacid,      0.03f ),
            ( WeenieClassName.swordlongelectric,  0.03f ),
            ( WeenieClassName.swordlongfire,      0.03f ),
            ( WeenieClassName.swordlongfrost,     0.03f ),
            ( WeenieClassName.swordbroad,         0.10f ),
            ( WeenieClassName.swordbroadacid,     0.03f ),
            ( WeenieClassName.swordbroadelectric, 0.03f ),
            ( WeenieClassName.swordbroadfire,     0.03f ),
            ( WeenieClassName.swordbroadfrost,    0.03f ),
        };

        private static ChanceTable<WeenieClassName> T3_T4_Chances = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.swordrapier,        0.06f ),
            ( WeenieClassName.swordshort,         0.06f ),
            ( WeenieClassName.swordshortacid,     0.01f ),
            ( WeenieClassName.swordshortelectric, 0.01f ),
            ( WeenieClassName.swordshortfire,     0.01f ),
            ( WeenieClassName.swordshortfrost,    0.01f ),
            ( WeenieClassName.scimitar,           0.12f ),
            ( WeenieClassName.scimitaracid,       0.04f ),
            ( WeenieClassName.scimitarelectric,   0.04f ),
            ( WeenieClassName.scimitarfire,       0.04f ),
            ( WeenieClassName.scimitarfrost,      0.04f ),
            ( WeenieClassName.swordlong,          0.12f ),
            ( WeenieClassName.swordlongacid,      0.04f ),
            ( WeenieClassName.swordlongelectric,  0.04f ),
            ( WeenieClassName.swordlongfire,      0.04f ),
            ( WeenieClassName.swordlongfrost,     0.04f ),
            ( WeenieClassName.swordbroad,         0.12f ),
            ( WeenieClassName.swordbroadacid,     0.04f ),
            ( WeenieClassName.swordbroadelectric, 0.04f ),
            ( WeenieClassName.swordbroadfire,     0.04f ),
            ( WeenieClassName.swordbroadfrost,    0.04f ),
        };

        private static ChanceTable<WeenieClassName> T5_T6_Chances = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.swordrapier,        0.01f ),
            ( WeenieClassName.swordshort,         0.01f ),
            ( WeenieClassName.swordshortacid,     0.01f ),
            ( WeenieClassName.swordshortelectric, 0.01f ),
            ( WeenieClassName.swordshortfire,     0.01f ),
            ( WeenieClassName.swordshortfrost,    0.01f ),
            ( WeenieClassName.scimitar,           0.14f ),
            ( WeenieClassName.scimitaracid,       0.04f ),
            ( WeenieClassName.scimitarelectric,   0.04f ),
            ( WeenieClassName.scimitarfire,       0.04f ),
            ( WeenieClassName.scimitarfrost,      0.04f ),
            ( WeenieClassName.swordlong,          0.14f ),
            ( WeenieClassName.swordlongacid,      0.04f ),
            ( WeenieClassName.swordlongelectric,  0.04f ),
            ( WeenieClassName.swordlongfire,      0.04f ),
            ( WeenieClassName.swordlongfrost,     0.04f ),
            ( WeenieClassName.swordbroad,         0.14f ),
            ( WeenieClassName.swordbroadacid,     0.05f ),
            ( WeenieClassName.swordbroadelectric, 0.05f ),
            ( WeenieClassName.swordbroadfire,     0.05f ),
            ( WeenieClassName.swordbroadfrost,    0.05f ),
        };

        private static readonly List<ChanceTable<WeenieClassName>> weaponTiers = new List<ChanceTable<WeenieClassName>>()
        {
            T1_T2_Chances,
            T1_T2_Chances,
            T3_T4_Chances,
            T3_T4_Chances,
            T5_T6_Chances,
            T5_T6_Chances,
        };
        static SwordWcids_Aluvian()
        {
            if (Common.ConfigManager.Config.Server.WorldRuleset == Common.Ruleset.CustomDM)
            {
                T1_Chances = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.swordshort,           3.0f ),
                    ( WeenieClassName.scimitar,             0.5f ),
                    ( WeenieClassName.swordlong,            0.5f ),
                    ( WeenieClassName.swordbroad,           0.5f ),

                    ( WeenieClassName.swordrapier,          0.25f ),
                    ( WeenieClassName.ace40618_spadone,     0.25f ),
                };

                T1_T2_Chances = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.swordshort,         4.0f ),
                    ( WeenieClassName.swordshortacid,     0.25f ),
                    ( WeenieClassName.swordshortelectric, 0.25f ),
                    ( WeenieClassName.swordshortfire,     0.25f ),
                    ( WeenieClassName.swordshortfrost,    0.25f ),

                    ( WeenieClassName.scimitar,         4.0f ),
                    ( WeenieClassName.scimitaracid,     0.25f ),
                    ( WeenieClassName.scimitarelectric, 0.25f ),
                    ( WeenieClassName.scimitarfire,     0.25f ),
                    ( WeenieClassName.scimitarfrost,    0.25f ),

                    ( WeenieClassName.swordlong,          4.0f ),
                    ( WeenieClassName.swordlongacid,      0.25f ),
                    ( WeenieClassName.swordlongelectric,  0.25f ),
                    ( WeenieClassName.swordlongfire,      0.25f ),
                    ( WeenieClassName.swordlongfrost,     0.25f ),

                    ( WeenieClassName.swordbroad,         4.0f ),
                    ( WeenieClassName.swordbroadacid,     0.25f ),
                    ( WeenieClassName.swordbroadelectric, 0.25f ),
                    ( WeenieClassName.swordbroadfire,     0.25f ),
                    ( WeenieClassName.swordbroadfrost,    0.25f ),

                    ( WeenieClassName.swordrapier,        2.0f ),

                    ( WeenieClassName.ace40618_spadone,          2.0f ), // Renamed to Greatsword to keep with the Aluvian theme
                    ( WeenieClassName.ace40619_acidspadone,      0.125f ),
                    ( WeenieClassName.ace40620_lightningspadone, 0.125f ),
                    ( WeenieClassName.ace40621_flamingspadone,   0.125f ),
                    ( WeenieClassName.ace40622_frostspadone,     0.125f ),
                };

                weaponTiers = new List<ChanceTable<WeenieClassName>>()
                {
                    T1_Chances,
                    T1_T2_Chances,
                    T1_T2_Chances,
                    T1_T2_Chances,
                    T1_T2_Chances,
                    T1_T2_Chances,
                };
            }
            else if (Common.ConfigManager.Config.Server.WorldRuleset <= Common.Ruleset.Infiltration)
            {
                T1_Chances = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.swordshort,           3.0f ),
                    ( WeenieClassName.scimitar,             0.5f ),
                    ( WeenieClassName.swordlong,            0.5f ),
                    ( WeenieClassName.swordbroad,           0.5f ),

                    ( WeenieClassName.swordrapier,          0.25f ),
                };

                T1_T2_Chances = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.swordshort,         4.0f ),
                    ( WeenieClassName.swordshortacid,     0.25f ),
                    ( WeenieClassName.swordshortelectric, 0.25f ),
                    ( WeenieClassName.swordshortfire,     0.25f ),
                    ( WeenieClassName.swordshortfrost,    0.25f ),

                    ( WeenieClassName.scimitar,           4.0f ),
                    ( WeenieClassName.scimitaracid,       0.25f ),
                    ( WeenieClassName.scimitarelectric,   0.25f ),
                    ( WeenieClassName.scimitarfire,       0.25f ),
                    ( WeenieClassName.scimitarfrost,      0.25f ),

                    ( WeenieClassName.swordlong,          4.0f ),
                    ( WeenieClassName.swordlongacid,      0.25f ),
                    ( WeenieClassName.swordlongelectric,  0.25f ),
                    ( WeenieClassName.swordlongfire,      0.25f ),
                    ( WeenieClassName.swordlongfrost,     0.25f ),

                    ( WeenieClassName.swordbroad,         4.0f ),
                    ( WeenieClassName.swordbroadacid,     0.25f ),
                    ( WeenieClassName.swordbroadelectric, 0.25f ),
                    ( WeenieClassName.swordbroadfire,     0.25f ),
                    ( WeenieClassName.swordbroadfrost,    0.25f ),

                    ( WeenieClassName.swordrapier,        2.0f ),
                };

                weaponTiers = new List<ChanceTable<WeenieClassName>>()
                {
                    T1_Chances,
                    T1_T2_Chances,
                    T1_T2_Chances,
                    T1_T2_Chances,
                    T1_T2_Chances,
                    T1_T2_Chances,
                };
            }
        }

        public static WeenieClassName Roll(int tier, out TreasureWeaponType weaponType)
        {
            // todo: add unique profiles for t7 / t8?
            tier = Math.Clamp(tier, 1, 6);

            var weapon = weaponTiers[tier - 1].Roll();

            switch(weapon)
            {
                case WeenieClassName.swordrapier:
                case WeenieClassName.swordshort:
                case WeenieClassName.swordshortacid:
                case WeenieClassName.swordshortelectric:
                case WeenieClassName.swordshortfire:
                case WeenieClassName.swordshortfrost:
                    weaponType = TreasureWeaponType.SwordMS;
                    break;
                case WeenieClassName.ace40618_spadone:
                case WeenieClassName.ace40619_acidspadone:
                case WeenieClassName.ace40620_lightningspadone:
                case WeenieClassName.ace40621_flamingspadone:
                case WeenieClassName.ace40622_frostspadone:
                    weaponType = TreasureWeaponType.TwoHandedSword;
                    break;
                default:
                    weaponType = TreasureWeaponType.Sword;
                    break;
            }

            return weapon;
        }
    }
}
