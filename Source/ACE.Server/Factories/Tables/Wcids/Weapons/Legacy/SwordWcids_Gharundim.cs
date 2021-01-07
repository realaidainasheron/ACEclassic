using System;
using System.Collections.Generic;

using ACE.Server.Factories.Entity;
using ACE.Server.Factories.Enum;

namespace ACE.Server.Factories.Tables.Wcids
{
    public static class SwordWcids_Gharundim
    {
        private static ChanceTable<WeenieClassName> T1_Chances;

        private static ChanceTable<WeenieClassName> T1_T2_Chances = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.swordrapier,      0.10f ),
            ( WeenieClassName.simi,             0.12f ),
            ( WeenieClassName.simiacid,         0.03f ),
            ( WeenieClassName.simielectric,     0.03f ),
            ( WeenieClassName.simifire,         0.03f ),
            ( WeenieClassName.simifrost,        0.03f ),
            ( WeenieClassName.kaskara,          0.10f ),
            ( WeenieClassName.kaskaraacid,      0.03f ),
            ( WeenieClassName.kaskaraelectric,  0.03f ),
            ( WeenieClassName.kaskarafire,      0.03f ),
            ( WeenieClassName.kaskarafrost,     0.03f ),
            ( WeenieClassName.shamshir,         0.10f ),
            ( WeenieClassName.shamshiracid,     0.03f ),
            ( WeenieClassName.shamshirelectric, 0.03f ),
            ( WeenieClassName.shamshirfire,     0.03f ),
            ( WeenieClassName.shamshirfrost,    0.03f ),
            ( WeenieClassName.takuba,           0.10f ),
            ( WeenieClassName.takubaacid,       0.03f ),
            ( WeenieClassName.takubaelectric,   0.03f ),
            ( WeenieClassName.takubafire,       0.03f ),
            ( WeenieClassName.takubafrost,      0.03f ),
        };

        private static ChanceTable<WeenieClassName> T3_T4_Chances = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.swordrapier,      0.06f ),
            ( WeenieClassName.simi,             0.06f ),
            ( WeenieClassName.simiacid,         0.01f ),
            ( WeenieClassName.simielectric,     0.01f ),
            ( WeenieClassName.simifire,         0.01f ),
            ( WeenieClassName.simifrost,        0.01f ),
            ( WeenieClassName.kaskara,          0.12f ),
            ( WeenieClassName.kaskaraacid,      0.04f ),
            ( WeenieClassName.kaskaraelectric,  0.04f ),
            ( WeenieClassName.kaskarafire,      0.04f ),
            ( WeenieClassName.kaskarafrost,     0.04f ),
            ( WeenieClassName.shamshir,         0.12f ),
            ( WeenieClassName.shamshiracid,     0.04f ),
            ( WeenieClassName.shamshirelectric, 0.04f ),
            ( WeenieClassName.shamshirfire,     0.04f ),
            ( WeenieClassName.shamshirfrost,    0.04f ),
            ( WeenieClassName.takuba,           0.12f ),
            ( WeenieClassName.takubaacid,       0.04f ),
            ( WeenieClassName.takubaelectric,   0.04f ),
            ( WeenieClassName.takubafire,       0.04f ),
            ( WeenieClassName.takubafrost,      0.04f ),
        };

        private static ChanceTable<WeenieClassName> T5_T6_Chances = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.swordrapier,      0.01f ),
            ( WeenieClassName.simi,             0.01f ),
            ( WeenieClassName.simiacid,         0.01f ),
            ( WeenieClassName.simielectric,     0.01f ),
            ( WeenieClassName.simifire,         0.01f ),
            ( WeenieClassName.simifrost,        0.01f ),
            ( WeenieClassName.kaskara,          0.14f ),
            ( WeenieClassName.kaskaraacid,      0.04f ),
            ( WeenieClassName.kaskaraelectric,  0.04f ),
            ( WeenieClassName.kaskarafire,      0.04f ),
            ( WeenieClassName.kaskarafrost,     0.04f ),
            ( WeenieClassName.shamshir,         0.14f ),
            ( WeenieClassName.shamshiracid,     0.04f ),
            ( WeenieClassName.shamshirelectric, 0.04f ),
            ( WeenieClassName.shamshirfire,     0.04f ),
            ( WeenieClassName.shamshirfrost,    0.04f ),
            ( WeenieClassName.takuba,           0.14f ),
            ( WeenieClassName.takubaacid,       0.05f ),
            ( WeenieClassName.takubaelectric,   0.05f ),
            ( WeenieClassName.takubafire,       0.05f ),
            ( WeenieClassName.takubafrost,      0.05f ),
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

        static SwordWcids_Gharundim()
        {
            if (Common.ConfigManager.Config.Server.WorldRuleset == Common.Ruleset.CustomDM)
            {
                T1_Chances = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.simi,                 3.00f ),
                    ( WeenieClassName.kaskara,              0.5f ),
                    ( WeenieClassName.shamshir,             0.5f ),
                    ( WeenieClassName.takuba,               0.5f ),

                    ( WeenieClassName.swordrapier,          0.25f ),
                    ( WeenieClassName.ace41067_shashqa,     0.25f ),
                };

                T1_T2_Chances = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.simi,             4.0f ),
                    ( WeenieClassName.simiacid,         0.25f ),
                    ( WeenieClassName.simielectric,     0.25f ),
                    ( WeenieClassName.simifire,         0.25f ),
                    ( WeenieClassName.simifrost,        0.25f ),

                    ( WeenieClassName.kaskara,          4.0f ),
                    ( WeenieClassName.kaskaraacid,      0.25f ),
                    ( WeenieClassName.kaskaraelectric,  0.25f ),
                    ( WeenieClassName.kaskarafire,      0.25f ),
                    ( WeenieClassName.kaskarafrost,     0.25f ),

                    ( WeenieClassName.shamshir,         4.0f ),
                    ( WeenieClassName.shamshiracid,     0.25f ),
                    ( WeenieClassName.shamshirelectric, 0.25f ),
                    ( WeenieClassName.shamshirfire,     0.25f ),
                    ( WeenieClassName.shamshirfrost,    0.25f ),

                    ( WeenieClassName.takuba,           4.0f ),
                    ( WeenieClassName.takubaacid,       0.25f ),
                    ( WeenieClassName.takubaelectric,   0.25f ),
                    ( WeenieClassName.takubafire,       0.25f ),
                    ( WeenieClassName.takubafrost,      0.25f ),

                    ( WeenieClassName.swordrapier,      2.0f ),

                    ( WeenieClassName.ace41067_shashqa,          2.0f ),
                    ( WeenieClassName.ace41068_acidshashqa,      0.125f ),
                    ( WeenieClassName.ace41069_lightningshashqa, 0.125f ),
                    ( WeenieClassName.ace41070_flamingshashqa,   0.125f ),
                    ( WeenieClassName.ace41071_frostshashqa,     0.125f ),
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
                    ( WeenieClassName.simi,                 3.0f ),
                    ( WeenieClassName.kaskara,              0.5f ),
                    ( WeenieClassName.shamshir,             0.5f ),
                    ( WeenieClassName.takuba,               0.5f ),

                    ( WeenieClassName.swordrapier,          0.25f ),
                };

                T1_T2_Chances = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.simi,             4.0f ),
                    ( WeenieClassName.simiacid,         0.25f ),
                    ( WeenieClassName.simielectric,     0.25f ),
                    ( WeenieClassName.simifire,         0.25f ),
                    ( WeenieClassName.simifrost,        0.25f ),

                    ( WeenieClassName.kaskara,          4.0f ),
                    ( WeenieClassName.kaskaraacid,      0.25f ),
                    ( WeenieClassName.kaskaraelectric,  0.25f ),
                    ( WeenieClassName.kaskarafire,      0.25f ),
                    ( WeenieClassName.kaskarafrost,     0.25f ),

                    ( WeenieClassName.shamshir,         4.0f ),
                    ( WeenieClassName.shamshiracid,     0.25f ),
                    ( WeenieClassName.shamshirelectric, 0.25f ),
                    ( WeenieClassName.shamshirfire,     0.25f ),
                    ( WeenieClassName.shamshirfrost,    0.25f ),

                    ( WeenieClassName.takuba,           4.0f ),
                    ( WeenieClassName.takubaacid,       0.25f ),
                    ( WeenieClassName.takubaelectric,   0.25f ),
                    ( WeenieClassName.takubafire,       0.25f ),
                    ( WeenieClassName.takubafrost,      0.25f ),

                    ( WeenieClassName.swordrapier,      2.0f ),
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

        public static WeenieClassName Roll(int tier)
        {
            // todo: add unique profiles for t7 / t8?
            tier = Math.Clamp(tier, 1, 6);

            return weaponTiers[tier - 1].Roll();
        }
    }
}
