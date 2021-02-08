using ACE.Server.Factories.Entity;
using ACE.Server.Factories.Enum;

using WeenieClassName = ACE.Server.Factories.Enum.WeenieClassName;

namespace ACE.Server.Factories.Tables.Wcids
{
    public static class AxeWcids
    {
        private static ChanceTable<WeenieClassName> AxeWcids_Aluvian_T1;

        private static ChanceTable<WeenieClassName> AxeWcids_Aluvian = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.axehand,           0.16f ),
            ( WeenieClassName.axehandacid,       0.04f ),
            ( WeenieClassName.axehandelectric,   0.04f ),
            ( WeenieClassName.axehandfire,       0.04f ),
            ( WeenieClassName.axehandfrost,      0.04f ),
            ( WeenieClassName.axebattle,         0.16f ),
            ( WeenieClassName.axebattleacid,     0.04f ),
            ( WeenieClassName.axebattleelectric, 0.04f ),
            ( WeenieClassName.axebattlefire,     0.04f ),
            ( WeenieClassName.axebattlefrost,    0.04f ),
            ( WeenieClassName.warhammer,         0.16f ),
            ( WeenieClassName.warhammeracid,     0.05f ),
            ( WeenieClassName.warhammerelectric, 0.05f ),
            ( WeenieClassName.warhammerfire,     0.05f ),
            ( WeenieClassName.warhammerfrost,    0.05f ),
        };

        private static ChanceTable<WeenieClassName> AxeWcids_Gharundim_T1;

        private static ChanceTable<WeenieClassName> AxeWcids_Gharundim = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.tungi,             0.16f ),
            ( WeenieClassName.tungiacid,         0.04f ),
            ( WeenieClassName.tungielectric,     0.04f ),
            ( WeenieClassName.tungifire,         0.04f ),
            ( WeenieClassName.tungifrost,        0.04f ),
            ( WeenieClassName.silifi,            0.16f ),
            ( WeenieClassName.silifiacid,        0.04f ),
            ( WeenieClassName.silifielectric,    0.04f ),
            ( WeenieClassName.silififire,        0.04f ),
            ( WeenieClassName.silififrost,       0.04f ),
            ( WeenieClassName.warhammer,         0.16f ),
            ( WeenieClassName.warhammeracid,     0.05f ),
            ( WeenieClassName.warhammerelectric, 0.05f ),
            ( WeenieClassName.warhammerfire,     0.05f ),
            ( WeenieClassName.warhammerfrost,    0.05f ),
        };

        private static ChanceTable<WeenieClassName> AxeWcids_Sho_T1;

        private static ChanceTable<WeenieClassName> AxeWcids_Sho = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.shouono,           0.16f ),
            ( WeenieClassName.shouonoacid,       0.04f ),
            ( WeenieClassName.shouonoelectric,   0.04f ),
            ( WeenieClassName.shouonofire,       0.04f ),
            ( WeenieClassName.shouonofrost,      0.04f ),
            ( WeenieClassName.ono,               0.16f ),
            ( WeenieClassName.onoacid,           0.04f ),
            ( WeenieClassName.onoelectric,       0.04f ),
            ( WeenieClassName.onofire,           0.04f ),
            ( WeenieClassName.onofrost,          0.04f ),
            ( WeenieClassName.warhammer,         0.16f ),
            ( WeenieClassName.warhammeracid,     0.05f ),
            ( WeenieClassName.warhammerelectric, 0.05f ),
            ( WeenieClassName.warhammerfire,     0.05f ),
            ( WeenieClassName.warhammerfrost,    0.05f ),
        };
        static AxeWcids()
        {
            if (Common.ConfigManager.Config.Server.WorldRuleset == Common.Ruleset.CustomDM)
            {
                AxeWcids_Aluvian_T1 = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.axehand,           3.0f ),
                    ( WeenieClassName.axebattle,         0.5f ),
                    ( WeenieClassName.warhammer,         0.5f ),
                    ( WeenieClassName.ace41052_greataxe, 0.5f ),
                };

                AxeWcids_Aluvian = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.axehand,           4.0f ),
                    ( WeenieClassName.axehandacid,       0.25f ),
                    ( WeenieClassName.axehandelectric,   0.25f ),
                    ( WeenieClassName.axehandfire,       0.25f ),
                    ( WeenieClassName.axehandfrost,      0.25f ),

                    ( WeenieClassName.axebattle,         4.0f ),
                    ( WeenieClassName.axebattleacid,     0.25f ),
                    ( WeenieClassName.axebattleelectric, 0.25f ),
                    ( WeenieClassName.axebattlefire,     0.25f ),
                    ( WeenieClassName.axebattlefrost,    0.25f ),

                    ( WeenieClassName.warhammer,         4.0f ),
                    ( WeenieClassName.warhammeracid,     0.25f ),
                    ( WeenieClassName.warhammerelectric, 0.25f ),
                    ( WeenieClassName.warhammerfire,     0.25f ),
                    ( WeenieClassName.warhammerfrost,    0.25f ),

                    ( WeenieClassName.ace41052_greataxe,          4.00f ),
                    ( WeenieClassName.ace41053_acidgreataxe,      0.25f ),
                    ( WeenieClassName.ace41054_lightninggreataxe, 0.25f ),
                    ( WeenieClassName.ace41055_flaminggreataxe,   0.25f ),
                    ( WeenieClassName.ace41056_frostgreataxe,     0.25f ),
                };

                AxeWcids_Gharundim_T1 = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.tungi,             3.0f ),
                    ( WeenieClassName.silifi,            0.5f ),
                    ( WeenieClassName.warhammer,         0.5f ),
                    ( WeenieClassName.ace41052_greataxe, 0.25f ),
                };

                AxeWcids_Gharundim = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.tungi,             4.0f ),
                    ( WeenieClassName.tungiacid,         0.25f ),
                    ( WeenieClassName.tungielectric,     0.25f ),
                    ( WeenieClassName.tungifire,         0.25f ),
                    ( WeenieClassName.tungifrost,        0.25f ),

                    ( WeenieClassName.silifi,            4.0f ),
                    ( WeenieClassName.silifiacid,        0.25f ),
                    ( WeenieClassName.silifielectric,    0.25f ),
                    ( WeenieClassName.silififire,        0.25f ),
                    ( WeenieClassName.silififrost,       0.25f ),

                    ( WeenieClassName.warhammer,         4.0f ),
                    ( WeenieClassName.warhammeracid,     0.25f ),
                    ( WeenieClassName.warhammerelectric, 0.25f ),
                    ( WeenieClassName.warhammerfire,     0.25f ),
                    ( WeenieClassName.warhammerfrost,    0.25f ),

                    ( WeenieClassName.ace41052_greataxe,          4.0f ),
                    ( WeenieClassName.ace41053_acidgreataxe,      0.25f ),
                    ( WeenieClassName.ace41054_lightninggreataxe, 0.25f ),
                    ( WeenieClassName.ace41055_flaminggreataxe,   0.25f ),
                    ( WeenieClassName.ace41056_frostgreataxe,     0.25f ),
                };


                AxeWcids_Sho_T1 = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.shouono,           3.0f ),
                    ( WeenieClassName.ono,               0.5f ),
                    ( WeenieClassName.warhammer,         0.5f ),
                    ( WeenieClassName.ace41052_greataxe, 0.5f ),
                };

                AxeWcids_Sho = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.shouono,           4.0f ),
                    ( WeenieClassName.shouonoacid,       0.25f ),
                    ( WeenieClassName.shouonoelectric,   0.25f ),
                    ( WeenieClassName.shouonofire,       0.25f ),
                    ( WeenieClassName.shouonofrost,      0.25f ),

                    ( WeenieClassName.ono,               4.0f ),
                    ( WeenieClassName.onoacid,           0.25f ),
                    ( WeenieClassName.onoelectric,       0.25f ),
                    ( WeenieClassName.onofire,           0.25f ),
                    ( WeenieClassName.onofrost,          0.25f ),

                    ( WeenieClassName.warhammer,         4.0f ),
                    ( WeenieClassName.warhammeracid,     0.25f ),
                    ( WeenieClassName.warhammerelectric, 0.25f ),
                    ( WeenieClassName.warhammerfire,     0.25f ),
                    ( WeenieClassName.warhammerfrost,    0.25f ),

                    ( WeenieClassName.ace41052_greataxe,          4.0f ),
                    ( WeenieClassName.ace41053_acidgreataxe,      0.25f ),
                    ( WeenieClassName.ace41054_lightninggreataxe, 0.25f ),
                    ( WeenieClassName.ace41055_flaminggreataxe,   0.25f ),
                    ( WeenieClassName.ace41056_frostgreataxe,     0.25f ),
                };
            }
            else if (Common.ConfigManager.Config.Server.WorldRuleset <= Common.Ruleset.Infiltration)
            {
                AxeWcids_Aluvian_T1 = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.axehand,           3.0f ),
                    ( WeenieClassName.axebattle,         0.5f ),
                    ( WeenieClassName.warhammer,         0.5f ),
                };

                AxeWcids_Aluvian = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.axehand,           0.27f ),
                    ( WeenieClassName.axehandacid,       0.016875f ),
                    ( WeenieClassName.axehandelectric,   0.016875f ),
                    ( WeenieClassName.axehandfire,       0.016875f ),
                    ( WeenieClassName.axehandfrost,      0.016875f ),

                    ( WeenieClassName.axebattle,         0.27f ),
                    ( WeenieClassName.axebattleacid,     0.016875f ),
                    ( WeenieClassName.axebattleelectric, 0.016875f ),
                    ( WeenieClassName.axebattlefire,     0.016875f ),
                    ( WeenieClassName.axebattlefrost,    0.016875f ),

                    ( WeenieClassName.warhammer,         0.26f ),
                    ( WeenieClassName.warhammeracid,     0.01625f ),
                    ( WeenieClassName.warhammerelectric, 0.01625f ),
                    ( WeenieClassName.warhammerfire,     0.01625f ),
                    ( WeenieClassName.warhammerfrost,    0.01625f ),
                };

                AxeWcids_Gharundim_T1 = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.tungi,             3.0f ),
                    ( WeenieClassName.silifi,            0.5f ),
                    ( WeenieClassName.warhammer,         0.5f ),
                };

                AxeWcids_Gharundim = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.tungi,             0.27f ),
                    ( WeenieClassName.tungiacid,         0.016875f ),
                    ( WeenieClassName.tungielectric,     0.016875f ),
                    ( WeenieClassName.tungifire,         0.016875f ),
                    ( WeenieClassName.tungifrost,        0.016875f ),

                    ( WeenieClassName.silifi,            0.27f ),
                    ( WeenieClassName.silifiacid,        0.016875f ),
                    ( WeenieClassName.silifielectric,    0.016875f ),
                    ( WeenieClassName.silififire,        0.016875f ),
                    ( WeenieClassName.silififrost,       0.016875f ),

                    ( WeenieClassName.warhammer,         0.26f ),
                    ( WeenieClassName.warhammeracid,     0.01625f ),
                    ( WeenieClassName.warhammerelectric, 0.01625f ),
                    ( WeenieClassName.warhammerfire,     0.01625f ),
                    ( WeenieClassName.warhammerfrost,    0.01625f ),
                };


                AxeWcids_Sho_T1 = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.shouono,           3.0f ),
                    ( WeenieClassName.ono,               0.5f ),
                    ( WeenieClassName.warhammer,         0.5f ),
                };

                AxeWcids_Sho = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.shouono,           0.27f ),
                    ( WeenieClassName.shouonoacid,       0.016875f ),
                    ( WeenieClassName.shouonoelectric,   0.016875f ),
                    ( WeenieClassName.shouonofire,       0.016875f ),
                    ( WeenieClassName.shouonofrost,      0.016875f ),

                    ( WeenieClassName.ono,               0.27f ),
                    ( WeenieClassName.onoacid,           0.016875f ),
                    ( WeenieClassName.onoelectric,       0.016875f ),
                    ( WeenieClassName.onofire,           0.016875f ),
                    ( WeenieClassName.onofrost,          0.016875f ),

                    ( WeenieClassName.warhammer,         0.26f ),
                    ( WeenieClassName.warhammeracid,     0.01625f ),
                    ( WeenieClassName.warhammerelectric, 0.01625f ),
                    ( WeenieClassName.warhammerfire,     0.01625f ),
                    ( WeenieClassName.warhammerfrost,    0.01625f ),
                };
            }
        }

        public static WeenieClassName Roll(TreasureHeritageGroup heritage, int tier, out TreasureWeaponType weaponType)
        {
            if (Common.ConfigManager.Config.Server.WorldRuleset == Common.Ruleset.CustomDM)
            {
                WeenieClassName weapon = WeenieClassName.undef;
                switch (heritage)
                {
                    case TreasureHeritageGroup.Aluvian:
                        if (tier > 1)
                            weapon = AxeWcids_Aluvian.Roll();
                        else
                            weapon = AxeWcids_Aluvian_T1.Roll();
                        break;
                    case TreasureHeritageGroup.Gharundim:
                        if (tier > 1)
                            weapon = AxeWcids_Gharundim.Roll();
                        else
                            weapon = AxeWcids_Gharundim_T1.Roll();
                        break;
                    case TreasureHeritageGroup.Sho:
                        if (tier > 1)
                            weapon = AxeWcids_Sho.Roll();
                        else
                            weapon = AxeWcids_Sho_T1.Roll();
                        break;
                }

                switch(weapon)
                {
                    case WeenieClassName.ace41052_greataxe:
                    case WeenieClassName.ace41053_acidgreataxe:
                    case WeenieClassName.ace41054_lightninggreataxe:
                    case WeenieClassName.ace41055_flaminggreataxe:
                    case WeenieClassName.ace41056_frostgreataxe:
                        weaponType = TreasureWeaponType.TwoHandedAxe;
                        break;
                    default:
                        weaponType = TreasureWeaponType.Axe;
                        break;
                }

                return weapon;
            }
            else if (Common.ConfigManager.Config.Server.WorldRuleset <= Common.Ruleset.Infiltration)
            {
                weaponType = TreasureWeaponType.Axe;
                switch (heritage)
                {
                    case TreasureHeritageGroup.Aluvian:
                        if(tier > 1)
                            return AxeWcids_Aluvian.Roll();
                        return AxeWcids_Aluvian_T1.Roll();

                    case TreasureHeritageGroup.Gharundim:
                        if (tier > 1)
                            return AxeWcids_Gharundim.Roll();
                        return AxeWcids_Gharundim_T1.Roll();

                    case TreasureHeritageGroup.Sho:
                        if (tier > 1)
                            return AxeWcids_Sho.Roll();
                        return AxeWcids_Sho_T1.Roll();
                }
            }
            else
            {
                weaponType = TreasureWeaponType.Axe;
                switch (heritage)
                {
                    case TreasureHeritageGroup.Aluvian:
                        return AxeWcids_Aluvian.Roll();

                    case TreasureHeritageGroup.Gharundim:
                        return AxeWcids_Gharundim.Roll();

                    case TreasureHeritageGroup.Sho:
                        return AxeWcids_Sho.Roll();
                }
            }
            weaponType = TreasureWeaponType.Undef;
            return WeenieClassName.undef;
        }
    }
}
