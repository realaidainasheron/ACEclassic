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
            if (Common.ConfigManager.Config.Server.WorldRuleset <= Common.Ruleset.Infiltration)
            {
                T1_Chances = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.swordrapier,          0.05f ),
                    ( WeenieClassName.simi,                 0.50f ),
                    ( WeenieClassName.kaskara,              0.15f ),
                    ( WeenieClassName.shamshir,             0.15f ),
                    ( WeenieClassName.takuba,               0.15f ),
                };

                T1_T2_Chances = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.swordrapier,      0.125f ),

                    ( WeenieClassName.simi,             0.34f ),
                    ( WeenieClassName.simiacid,         0.02125f ),
                    ( WeenieClassName.simielectric,     0.02125f ),
                    ( WeenieClassName.simifire,         0.02125f ),
                    ( WeenieClassName.simifrost,        0.02125f ),

                    ( WeenieClassName.kaskara,          0.12f ),
                    ( WeenieClassName.kaskaraacid,      0.0075f ),
                    ( WeenieClassName.kaskaraelectric,  0.0075f ),
                    ( WeenieClassName.kaskarafire,      0.0075f ),
                    ( WeenieClassName.kaskarafrost,     0.0075f ),

                    ( WeenieClassName.shamshir,         0.12f ),
                    ( WeenieClassName.shamshiracid,     0.0075f ),
                    ( WeenieClassName.shamshirelectric, 0.0075f ),
                    ( WeenieClassName.shamshirfire,     0.0075f ),
                    ( WeenieClassName.shamshirfrost,    0.0075f ),

                    ( WeenieClassName.takuba,           0.12f ),
                    ( WeenieClassName.takubaacid,       0.0075f ),
                    ( WeenieClassName.takubaelectric,   0.0075f ),
                    ( WeenieClassName.takubafire,       0.0075f ),
                    ( WeenieClassName.takubafrost,      0.0075f ),
                };

                T3_T4_Chances = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.swordrapier,      0.05f ),

                    ( WeenieClassName.simi,             0.1f ),
                    ( WeenieClassName.simiacid,         0.00625f ),
                    ( WeenieClassName.simielectric,     0.00625f ),
                    ( WeenieClassName.simifire,         0.00625f ),
                    ( WeenieClassName.simifrost,        0.00625f ),

                    ( WeenieClassName.kaskara,          0.22f ),
                    ( WeenieClassName.kaskaraacid,      0.01375f ),
                    ( WeenieClassName.kaskaraelectric,  0.01375f ),
                    ( WeenieClassName.kaskarafire,      0.01375f ),
                    ( WeenieClassName.kaskarafrost,     0.01375f ),

                    ( WeenieClassName.shamshir,         0.22f ),
                    ( WeenieClassName.shamshiracid,     0.01375f ),
                    ( WeenieClassName.shamshirelectric, 0.01375f ),
                    ( WeenieClassName.shamshirfire,     0.01375f ),
                    ( WeenieClassName.shamshirfrost,    0.01375f ),

                    ( WeenieClassName.takuba,           0.22f ),
                    ( WeenieClassName.takubaacid,       0.01375f ),
                    ( WeenieClassName.takubaelectric,   0.01375f ),
                    ( WeenieClassName.takubafire,       0.01375f ),
                    ( WeenieClassName.takubafrost,      0.01375f ),
                };

                T5_T6_Chances = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.swordrapier,      0.03125f ),

                    ( WeenieClassName.simi,             0.025f ),
                    ( WeenieClassName.simiacid,         0.0015625f ),
                    ( WeenieClassName.simielectric,     0.0015625f ),
                    ( WeenieClassName.simifire,         0.0015625f ),
                    ( WeenieClassName.simifrost,        0.0015625f ),

                    ( WeenieClassName.kaskara,          0.25f ),
                    ( WeenieClassName.kaskaraacid,      0.015625f ),
                    ( WeenieClassName.kaskaraelectric,  0.015625f ),
                    ( WeenieClassName.kaskarafire,      0.015625f ),
                    ( WeenieClassName.kaskarafrost,     0.015625f ),

                    ( WeenieClassName.shamshir,         0.25f ),
                    ( WeenieClassName.shamshiracid,     0.015625f ),
                    ( WeenieClassName.shamshirelectric, 0.015625f ),
                    ( WeenieClassName.shamshirfire,     0.015625f ),
                    ( WeenieClassName.shamshirfrost,    0.015625f ),

                    ( WeenieClassName.takuba,           0.25f ),
                    ( WeenieClassName.takubaacid,       0.015625f ),
                    ( WeenieClassName.takubaelectric,   0.015625f ),
                    ( WeenieClassName.takubafire,       0.015625f ),
                    ( WeenieClassName.takubafrost,      0.015625f ),
                };

                weaponTiers = new List<ChanceTable<WeenieClassName>>()
                {
                    T1_Chances,
                    T1_T2_Chances,
                    T3_T4_Chances,
                    T3_T4_Chances,
                    T5_T6_Chances,
                    T5_T6_Chances,
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
