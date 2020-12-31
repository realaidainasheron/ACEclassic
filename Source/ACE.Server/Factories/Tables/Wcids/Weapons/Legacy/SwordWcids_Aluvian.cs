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
            if (Common.ConfigManager.Config.Server.WorldRuleset == Common.Ruleset.Infiltration)
            {
                T1_Chances = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.swordrapier,          0.05f ),
                    ( WeenieClassName.swordshort,           0.50f ),
                    ( WeenieClassName.scimitar,             0.15f ),
                    ( WeenieClassName.swordlong,            0.15f ),
                    ( WeenieClassName.swordbroad,           0.15f ),
                };

                T1_T2_Chances = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.swordrapier,        0.125f ),

                    ( WeenieClassName.swordshort,         0.34f ),
                    ( WeenieClassName.swordshortacid,     0.02125f ),
                    ( WeenieClassName.swordshortelectric, 0.02125f ),
                    ( WeenieClassName.swordshortfire,     0.02125f ),
                    ( WeenieClassName.swordshortfrost,    0.02125f ),

                    ( WeenieClassName.scimitar,         0.12f ),
                    ( WeenieClassName.scimitaracid,     0.0075f ),
                    ( WeenieClassName.scimitarelectric, 0.0075f ),
                    ( WeenieClassName.scimitarfire,     0.0075f ),
                    ( WeenieClassName.scimitarfrost,    0.0075f ),

                    ( WeenieClassName.swordlong,          0.12f ),
                    ( WeenieClassName.swordlongacid,      0.0075f ),
                    ( WeenieClassName.swordlongelectric,  0.0075f ),
                    ( WeenieClassName.swordlongfire,      0.0075f ),
                    ( WeenieClassName.swordlongfrost,     0.0075f ),

                    ( WeenieClassName.swordbroad,         0.12f ),
                    ( WeenieClassName.swordbroadacid,     0.0075f ),
                    ( WeenieClassName.swordbroadelectric, 0.0075f ),
                    ( WeenieClassName.swordbroadfire,     0.0075f ),
                    ( WeenieClassName.swordbroadfrost,    0.0075f ),
                };

                T3_T4_Chances = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.swordrapier,        0.05f ),

                    ( WeenieClassName.swordshort,         0.1f ),
                    ( WeenieClassName.swordshortacid,     0.00625f ),
                    ( WeenieClassName.swordshortelectric, 0.00625f ),
                    ( WeenieClassName.swordshortfire,     0.00625f ),
                    ( WeenieClassName.swordshortfrost,    0.00625f ),

                    ( WeenieClassName.scimitar,         0.22f ),
                    ( WeenieClassName.scimitaracid,     0.01375f ),
                    ( WeenieClassName.scimitarelectric, 0.01375f ),
                    ( WeenieClassName.scimitarfire,     0.01375f ),
                    ( WeenieClassName.scimitarfrost,    0.01375f ),

                    ( WeenieClassName.swordlong,          0.22f ),
                    ( WeenieClassName.swordlongacid,      0.01375f ),
                    ( WeenieClassName.swordlongelectric,  0.01375f ),
                    ( WeenieClassName.swordlongfire,      0.01375f ),
                    ( WeenieClassName.swordlongfrost,     0.01375f ),

                    ( WeenieClassName.swordbroad,         0.22f ),
                    ( WeenieClassName.swordbroadacid,     0.01375f ),
                    ( WeenieClassName.swordbroadelectric, 0.01375f ),
                    ( WeenieClassName.swordbroadfire,     0.01375f ),
                    ( WeenieClassName.swordbroadfrost,    0.01375f ),
                };

                T5_T6_Chances = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.swordrapier,        0.03125f ),

                    ( WeenieClassName.swordshort,         0.025f ),
                    ( WeenieClassName.swordshortacid,     0.0015625f ),
                    ( WeenieClassName.swordshortelectric, 0.0015625f ),
                    ( WeenieClassName.swordshortfire,     0.0015625f ),
                    ( WeenieClassName.swordshortfrost,    0.0015625f ),

                    ( WeenieClassName.scimitar,         0.25f ),
                    ( WeenieClassName.scimitaracid,     0.015625f ),
                    ( WeenieClassName.scimitarelectric, 0.015625f ),
                    ( WeenieClassName.scimitarfire,     0.015625f ),
                    ( WeenieClassName.scimitarfrost,    0.015625f ),

                    ( WeenieClassName.swordlong,          0.25f ),
                    ( WeenieClassName.swordlongacid,      0.015625f ),
                    ( WeenieClassName.swordlongelectric,  0.015625f ),
                    ( WeenieClassName.swordlongfire,      0.015625f ),
                    ( WeenieClassName.swordlongfrost,     0.015625f ),

                    ( WeenieClassName.swordbroad,         0.25f ),
                    ( WeenieClassName.swordbroadacid,     0.015625f ),
                    ( WeenieClassName.swordbroadelectric, 0.015625f ),
                    ( WeenieClassName.swordbroadfire,     0.015625f ),
                    ( WeenieClassName.swordbroadfrost,    0.015625f ),
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
