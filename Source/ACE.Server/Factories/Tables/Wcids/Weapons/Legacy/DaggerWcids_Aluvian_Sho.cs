using System;
using System.Collections.Generic;

using ACE.Server.Factories.Entity;
using ACE.Server.Factories.Enum;

namespace ACE.Server.Factories.Tables.Wcids
{
    public static class DaggerWcids_Aluvian_Sho
    {
        private static ChanceTable<WeenieClassName> T1_Chances;

        private static ChanceTable<WeenieClassName> T1_T3_Chances = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.knife,          0.16f ),
            ( WeenieClassName.knifeacid,      0.04f ),
            ( WeenieClassName.knifeelectric,  0.04f ),
            ( WeenieClassName.knifefire,      0.04f ),
            ( WeenieClassName.knifefrost,     0.04f ),
            ( WeenieClassName.dagger,         0.16f ),
            ( WeenieClassName.daggeracid,     0.04f ),
            ( WeenieClassName.daggerelectric, 0.04f ),
            ( WeenieClassName.daggerfire,     0.04f ),
            ( WeenieClassName.daggerfrost,    0.04f ),
            ( WeenieClassName.dirk,           0.16f ),
            ( WeenieClassName.dirkacid,       0.05f ),
            ( WeenieClassName.dirkelectric,   0.05f ),
            ( WeenieClassName.dirkfire,       0.05f ),
            ( WeenieClassName.dirkfrost,      0.05f ),
        };

        private static ChanceTable<WeenieClassName> T4_Chances = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.knife,          0.06f ),
            ( WeenieClassName.knifeacid,      0.01f ),
            ( WeenieClassName.knifeelectric,  0.01f ),
            ( WeenieClassName.knifefire,      0.01f ),
            ( WeenieClassName.knifefrost,     0.01f ),
            ( WeenieClassName.dagger,         0.06f ),
            ( WeenieClassName.daggeracid,     0.01f ),
            ( WeenieClassName.daggerelectric, 0.01f ),
            ( WeenieClassName.daggerfire,     0.01f ),
            ( WeenieClassName.daggerfrost,    0.01f ),
            ( WeenieClassName.dirk,           0.40f ),
            ( WeenieClassName.dirkacid,       0.10f ),
            ( WeenieClassName.dirkelectric,   0.10f ),
            ( WeenieClassName.dirkfire,       0.10f ),
            ( WeenieClassName.dirkfrost,      0.10f ),
        };

        private static ChanceTable<WeenieClassName> T5_T6_Chances = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.knife,          0.01f ),
            ( WeenieClassName.knifeacid,      0.01f ),
            ( WeenieClassName.knifeelectric,  0.01f ),
            ( WeenieClassName.knifefire,      0.01f ),
            ( WeenieClassName.knifefrost,     0.01f ),
            ( WeenieClassName.dagger,         0.01f ),
            ( WeenieClassName.daggeracid,     0.01f ),
            ( WeenieClassName.daggerelectric, 0.01f ),
            ( WeenieClassName.daggerfire,     0.01f ),
            ( WeenieClassName.daggerfrost,    0.01f ),
            ( WeenieClassName.dirk,           0.42f ),
            ( WeenieClassName.dirkacid,       0.12f ),
            ( WeenieClassName.dirkelectric,   0.12f ),
            ( WeenieClassName.dirkfire,       0.12f ),
            ( WeenieClassName.dirkfrost,      0.12f ),
        };

        private static readonly List<ChanceTable<WeenieClassName>> weaponTiers = new List<ChanceTable<WeenieClassName>>()
        {
            T1_T3_Chances,
            T1_T3_Chances,
            T1_T3_Chances,
            T4_Chances,
            T5_T6_Chances,
            T5_T6_Chances,
        };
        static DaggerWcids_Aluvian_Sho()
        {
            if (Common.ConfigManager.Config.Server.WorldRuleset == Common.Ruleset.Infiltration)
            {
                T1_Chances = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.knife,          0.45f ),
                    ( WeenieClassName.dagger,         0.45f ),
                    ( WeenieClassName.dirk,           0.10f ),
                };

                T1_T3_Chances = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.knife,          0.25f ),
                    ( WeenieClassName.knifeacid,      0.02f ),
                    ( WeenieClassName.knifeelectric,  0.02f ),
                    ( WeenieClassName.knifefire,      0.02f ),
                    ( WeenieClassName.knifefrost,     0.02f ),

                    ( WeenieClassName.dagger,         0.26f ),
                    ( WeenieClassName.daggeracid,     0.02f ),
                    ( WeenieClassName.daggerelectric, 0.02f ),
                    ( WeenieClassName.daggerfire,     0.02f ),
                    ( WeenieClassName.daggerfrost,    0.02f ),

                    ( WeenieClassName.dirk,           0.25f ),
                    ( WeenieClassName.dirkacid,       0.02f ),
                    ( WeenieClassName.dirkelectric,   0.02f ),
                    ( WeenieClassName.dirkfire,       0.02f ),
                    ( WeenieClassName.dirkfrost,      0.02f ),
                };

                T4_Chances = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.knife,          0.15f ),
                    ( WeenieClassName.knifeacid,      0.009375f ),
                    ( WeenieClassName.knifeelectric,  0.009375f ),
                    ( WeenieClassName.knifefire,      0.009375f ),
                    ( WeenieClassName.knifefrost,     0.009375f ),

                    ( WeenieClassName.dagger,         0.15f ),
                    ( WeenieClassName.daggeracid,     0.009375f ),
                    ( WeenieClassName.daggerelectric, 0.009375f ),
                    ( WeenieClassName.daggerfire,     0.009375f ),
                    ( WeenieClassName.daggerfrost,    0.009375f ),

                    ( WeenieClassName.dirk,           0.5f ),
                    ( WeenieClassName.dirkacid,       0.03125f ),
                    ( WeenieClassName.dirkelectric,   0.03125f ),
                    ( WeenieClassName.dirkfire,       0.03125f ),
                    ( WeenieClassName.dirkfrost,      0.03125f ),
                };

                T5_T6_Chances = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.knife,          0.1f ),
                    ( WeenieClassName.knifeacid,      0.00625f ),
                    ( WeenieClassName.knifeelectric,  0.00625f ),
                    ( WeenieClassName.knifefire,      0.00625f ),
                    ( WeenieClassName.knifefrost,     0.00625f ),

                    ( WeenieClassName.dagger,         0.1f ),
                    ( WeenieClassName.daggeracid,     0.00625f ),
                    ( WeenieClassName.daggerelectric, 0.00625f ),
                    ( WeenieClassName.daggerfire,     0.00625f ),
                    ( WeenieClassName.daggerfrost,    0.00625f ),

                    ( WeenieClassName.dirk,           0.6f ),
                    ( WeenieClassName.dirkacid,       0.0375f ),
                    ( WeenieClassName.dirkelectric,   0.0375f ),
                    ( WeenieClassName.dirkfire,       0.0375f ),
                    ( WeenieClassName.dirkfrost,      0.0375f ),
                };

                weaponTiers = new List<ChanceTable<WeenieClassName>>()
                {
                    T1_Chances,
                    T1_T3_Chances,
                    T1_T3_Chances,
                    T4_Chances,
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
