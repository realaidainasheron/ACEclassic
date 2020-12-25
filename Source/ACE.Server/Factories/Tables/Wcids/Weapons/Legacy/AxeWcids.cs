using ACE.Server.Factories.Entity;
using ACE.Server.Factories.Enum;

using WeenieClassName = ACE.Server.Factories.Enum.WeenieClassName;

namespace ACE.Server.Factories.Tables.Wcids
{
    public static class AxeWcids
    {
        private static ChanceTable<WeenieClassName> AxeWcids_Aluvians_Non_Elemental = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.axehand,           0.33f ),
            ( WeenieClassName.axebattle,         0.34f ),
            ( WeenieClassName.warhammer,         0.33f ),
        };

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

        private static ChanceTable<WeenieClassName> AxeWcids_Gharundim_Non_Elemental = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.tungi,             0.33f ),
            ( WeenieClassName.silifi,            0.34f ),
            ( WeenieClassName.warhammer,         0.33f ),
        };

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

        private static ChanceTable<WeenieClassName> AxeWcids_Sho_Non_Elemental = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.shouono,           0.33f ),
            ( WeenieClassName.ono,               0.34f ),
            ( WeenieClassName.warhammer,         0.33f ),
        };

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
            if(Common.ConfigManager.Config.Server.WorldRuleset == Common.Ruleset.Infiltration)
            {
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
                    ( WeenieClassName.warhammeracid,     0.01687f ),
                    ( WeenieClassName.warhammerelectric, 0.01687f ),
                    ( WeenieClassName.warhammerfire,     0.01687f ),
                    ( WeenieClassName.warhammerfrost,    0.01687f ),
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
                    ( WeenieClassName.warhammeracid,     0.01687f ),
                    ( WeenieClassName.warhammerelectric, 0.01687f ),
                    ( WeenieClassName.warhammerfire,     0.01687f ),
                    ( WeenieClassName.warhammerfrost,    0.01687f ),
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
                    ( WeenieClassName.warhammeracid,     0.01687f ),
                    ( WeenieClassName.warhammerelectric, 0.01687f ),
                    ( WeenieClassName.warhammerfire,     0.01687f ),
                    ( WeenieClassName.warhammerfrost,    0.01687f ),
                };
            }
        }

        public static WeenieClassName Roll(TreasureHeritageGroup heritage, int tier)
        {
            if (Common.ConfigManager.Config.Server.WorldRuleset == Common.Ruleset.EoR)
            {
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
            else
            {
                switch (heritage)
                {
                    case TreasureHeritageGroup.Aluvian:
                        if(tier > 1)
                            return AxeWcids_Aluvian.Roll();
                        return AxeWcids_Aluvians_Non_Elemental.Roll();

                    case TreasureHeritageGroup.Gharundim:
                        if (tier > 1)
                            return AxeWcids_Gharundim.Roll();
                        return AxeWcids_Gharundim_Non_Elemental.Roll();

                    case TreasureHeritageGroup.Sho:
                        if (tier > 1)
                            return AxeWcids_Sho.Roll();
                        return AxeWcids_Sho_Non_Elemental.Roll();
                }
            }
            return WeenieClassName.undef;
        }
    }
}
