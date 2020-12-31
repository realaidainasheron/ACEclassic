using ACE.Server.Factories.Entity;
using ACE.Server.Factories.Enum;

using WeenieClassName = ACE.Server.Factories.Enum.WeenieClassName;

namespace ACE.Server.Factories.Tables.Wcids
{
    public static class SpearWcids
    {
        private static ChanceTable<WeenieClassName> SpearWcids_Aluvian_T1;

        private static ChanceTable<WeenieClassName> SpearWcids_Aluvian = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.spear,              0.16f ),
            ( WeenieClassName.spearacid,          0.04f ),
            ( WeenieClassName.spearelectric,      0.04f ),
            ( WeenieClassName.spearflame,         0.04f ),
            ( WeenieClassName.spearfrost,         0.04f ),
            ( WeenieClassName.trident,            0.16f ),
            ( WeenieClassName.tridentacid,        0.04f ),
            ( WeenieClassName.tridentelectric,    0.04f ),
            ( WeenieClassName.tridentfire,        0.04f ),
            ( WeenieClassName.tridentfrost,       0.04f ),
            ( WeenieClassName.swordstaff,         0.16f ),
            ( WeenieClassName.swordstaffacid,     0.05f ),
            ( WeenieClassName.swordstaffelectric, 0.05f ),
            ( WeenieClassName.swordstafffire,     0.05f ),
            ( WeenieClassName.swordstafffrost,    0.05f ),
        };

        private static ChanceTable<WeenieClassName> SpearWcids_Gharundim_T1;

        private static ChanceTable<WeenieClassName> SpearWcids_Gharundim = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.budiaq,             0.16f ),
            ( WeenieClassName.budiaqacid,         0.04f ),
            ( WeenieClassName.budiaqelectric,     0.04f ),
            ( WeenieClassName.budiaqfire,         0.04f ),
            ( WeenieClassName.budiaqfrost,        0.04f ),
            ( WeenieClassName.trident,            0.16f ),
            ( WeenieClassName.tridentacid,        0.04f ),
            ( WeenieClassName.tridentelectric,    0.04f ),
            ( WeenieClassName.tridentfire,        0.04f ),
            ( WeenieClassName.tridentfrost,       0.04f ),
            ( WeenieClassName.swordstaff,         0.16f ),
            ( WeenieClassName.swordstaffacid,     0.05f ),
            ( WeenieClassName.swordstaffelectric, 0.05f ),
            ( WeenieClassName.swordstafffire,     0.05f ),
            ( WeenieClassName.swordstafffrost,    0.05f ),
        };

        private static ChanceTable<WeenieClassName> SpearWcids_Sho_T1 = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.yari,                0.34f ),
            ( WeenieClassName.trident,             0.33f ),
            ( WeenieClassName.swordstaff,          0.33f ),
        };

        private static ChanceTable<WeenieClassName> SpearWcids_Sho = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.yari,               0.16f ),
            ( WeenieClassName.yariacid,           0.04f ),
            ( WeenieClassName.yarielectric,       0.04f ),
            ( WeenieClassName.yarifire,           0.04f ),
            ( WeenieClassName.yarifrost,          0.04f ),
            ( WeenieClassName.trident,            0.16f ),
            ( WeenieClassName.tridentacid,        0.04f ),
            ( WeenieClassName.tridentelectric,    0.04f ),
            ( WeenieClassName.tridentfire,        0.04f ),
            ( WeenieClassName.tridentfrost,       0.04f ),
            ( WeenieClassName.swordstaff,         0.16f ),
            ( WeenieClassName.swordstaffacid,     0.05f ),
            ( WeenieClassName.swordstaffelectric, 0.05f ),
            ( WeenieClassName.swordstafffire,     0.05f ),
            ( WeenieClassName.swordstafffrost,    0.05f ),
        };
        static SpearWcids()
        {
            if (Common.ConfigManager.Config.Server.WorldRuleset == Common.Ruleset.Infiltration)
            {
                SpearWcids_Aluvian_T1 = new ChanceTable<WeenieClassName>(true)
                {
                    ( WeenieClassName.spear,               1.0f ),

                    ( WeenieClassName.trident,             0.25f ),
                    ( WeenieClassName.swordstaff,          0.25f ),
                };

                SpearWcids_Aluvian = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.spear,              0.27f ),
                    ( WeenieClassName.spearacid,          0.016875f ),
                    ( WeenieClassName.spearelectric,      0.016875f ),
                    ( WeenieClassName.spearflame,         0.016875f ),
                    ( WeenieClassName.spearfrost,         0.016875f ),

                    ( WeenieClassName.trident,            0.27f ),
                    ( WeenieClassName.tridentacid,        0.016875f ),
                    ( WeenieClassName.tridentelectric,    0.016875f ),
                    ( WeenieClassName.tridentfire,        0.016875f ),
                    ( WeenieClassName.tridentfrost,       0.016875f ),

                    ( WeenieClassName.swordstaff,         0.26f ),
                    ( WeenieClassName.swordstaffacid,     0.01625f ),
                    ( WeenieClassName.swordstaffelectric, 0.01625f ),
                    ( WeenieClassName.swordstafffire,     0.01625f ),
                    ( WeenieClassName.swordstafffrost,    0.01625f ),
                };

                SpearWcids_Gharundim_T1 = new ChanceTable<WeenieClassName>(true)
                {
                    ( WeenieClassName.budiaq,              1.00f ),

                    ( WeenieClassName.trident,             0.25f ),
                    ( WeenieClassName.swordstaff,          0.25f ),
                };

                SpearWcids_Gharundim = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.budiaq,             0.27f ),
                    ( WeenieClassName.budiaqacid,         0.016875f ),
                    ( WeenieClassName.budiaqelectric,     0.016875f ),
                    ( WeenieClassName.budiaqfire,         0.016875f ),
                    ( WeenieClassName.budiaqfrost,        0.016875f ),

                    ( WeenieClassName.trident,            0.27f ),
                    ( WeenieClassName.tridentacid,        0.016875f ),
                    ( WeenieClassName.tridentelectric,    0.016875f ),
                    ( WeenieClassName.tridentfire,        0.016875f ),
                    ( WeenieClassName.tridentfrost,       0.016875f ),

                    ( WeenieClassName.swordstaff,         0.26f ),
                    ( WeenieClassName.swordstaffacid,     0.01625f ),
                    ( WeenieClassName.swordstaffelectric, 0.01625f ),
                    ( WeenieClassName.swordstafffire,     0.01625f ),
                    ( WeenieClassName.swordstafffrost,    0.01625f ),
                };

                SpearWcids_Sho_T1 = new ChanceTable<WeenieClassName>(true)
                {
                    ( WeenieClassName.yari,                1.00f ),

                    ( WeenieClassName.trident,             0.25f ),
                    ( WeenieClassName.swordstaff,          0.25f ),
                };

                SpearWcids_Sho = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.yari,               0.27f ),
                    ( WeenieClassName.yariacid,           0.016875f ),
                    ( WeenieClassName.yarielectric,       0.016875f ),
                    ( WeenieClassName.yarifire,           0.016875f ),
                    ( WeenieClassName.yarifrost,          0.016875f ),

                    ( WeenieClassName.trident,            0.27f ),
                    ( WeenieClassName.tridentacid,        0.016875f ),
                    ( WeenieClassName.tridentelectric,    0.016875f ),
                    ( WeenieClassName.tridentfire,        0.016875f ),
                    ( WeenieClassName.tridentfrost,       0.016875f ),

                    ( WeenieClassName.swordstaff,         0.26f ),
                    ( WeenieClassName.swordstaffacid,     0.01625f ),
                    ( WeenieClassName.swordstaffelectric, 0.01625f ),
                    ( WeenieClassName.swordstafffire,     0.01625f ),
                    ( WeenieClassName.swordstafffrost,    0.01625f ),
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
                        return SpearWcids_Aluvian.Roll();

                    case TreasureHeritageGroup.Gharundim:
                        return SpearWcids_Gharundim.Roll();

                    case TreasureHeritageGroup.Sho:
                        return SpearWcids_Sho.Roll();
                }
            }
            else
            {
                switch (heritage)
                {
                    case TreasureHeritageGroup.Aluvian:
                        if (tier > 1)
                            return SpearWcids_Aluvian.Roll();
                        return SpearWcids_Aluvian_T1.Roll();

                    case TreasureHeritageGroup.Gharundim:
                        if (tier > 1)
                            return SpearWcids_Gharundim.Roll();
                        return SpearWcids_Gharundim_T1.Roll();

                    case TreasureHeritageGroup.Sho:
                        if (tier > 1)
                            return SpearWcids_Sho.Roll();
                        return SpearWcids_Sho_T1.Roll();
                }
            }
            return WeenieClassName.undef;
        }
    }
}
