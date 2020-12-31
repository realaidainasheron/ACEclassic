using System;
using System.Collections.Generic;

using ACE.Server.Factories.Entity;
using ACE.Server.Factories.Enum;

namespace ACE.Server.Factories.Tables.Wcids
{
    public static class SwordWcids_Sho
    {
        private static ChanceTable<WeenieClassName> T1_Chances;

        private static ChanceTable<WeenieClassName> T1_T2_Chances = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.swordrapier,      0.10f ),
            ( WeenieClassName.yaoji,            0.12f ),
            ( WeenieClassName.yaojiacid,        0.03f ),
            ( WeenieClassName.yaojielectric,    0.03f ),
            ( WeenieClassName.yaojifire,        0.03f ),
            ( WeenieClassName.yaojifrost,       0.03f ),
            ( WeenieClassName.scimitar,         0.10f ),
            ( WeenieClassName.scimitaracid,     0.03f ),
            ( WeenieClassName.scimitarelectric, 0.03f ),
            ( WeenieClassName.scimitarfire,     0.03f ),
            ( WeenieClassName.scimitarfrost,    0.03f ),
            ( WeenieClassName.ken,              0.10f ),
            ( WeenieClassName.kenacid,          0.03f ),
            ( WeenieClassName.kenelectric,      0.03f ),
            ( WeenieClassName.kenfire,          0.03f ),
            ( WeenieClassName.kenfrost,         0.03f ),
            ( WeenieClassName.tachi,            0.10f ),
            ( WeenieClassName.tachiacid,        0.03f ),
            ( WeenieClassName.tachielectric,    0.03f ),
            ( WeenieClassName.tachifire,        0.03f ),
            ( WeenieClassName.tachifrost,       0.03f ),
        };

        private static ChanceTable<WeenieClassName> T3_T4_Chances = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.swordrapier,      0.06f ),
            ( WeenieClassName.yaoji,            0.06f ),
            ( WeenieClassName.yaojiacid,        0.01f ),
            ( WeenieClassName.yaojielectric,    0.01f ),
            ( WeenieClassName.yaojifire,        0.01f ),
            ( WeenieClassName.yaojifrost,       0.01f ),
            ( WeenieClassName.scimitar,         0.12f ),
            ( WeenieClassName.scimitaracid,     0.04f ),
            ( WeenieClassName.scimitarelectric, 0.04f ),
            ( WeenieClassName.scimitarfire,     0.04f ),
            ( WeenieClassName.scimitarfrost,    0.04f ),
            ( WeenieClassName.ken,              0.12f ),
            ( WeenieClassName.kenacid,          0.04f ),
            ( WeenieClassName.kenelectric,      0.04f ),
            ( WeenieClassName.kenfire,          0.04f ),
            ( WeenieClassName.kenfrost,         0.04f ),
            ( WeenieClassName.tachi,            0.12f ),
            ( WeenieClassName.tachiacid,        0.04f ),
            ( WeenieClassName.tachielectric,    0.04f ),
            ( WeenieClassName.tachifire,        0.04f ),
            ( WeenieClassName.tachifrost,       0.04f ),
        };

        private static ChanceTable<WeenieClassName> T5_T6_Chances = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.swordrapier,      0.01f ),
            ( WeenieClassName.yaoji,            0.01f ),
            ( WeenieClassName.yaojiacid,        0.01f ),
            ( WeenieClassName.yaojielectric,    0.01f ),
            ( WeenieClassName.yaojifire,        0.01f ),
            ( WeenieClassName.yaojifrost,       0.01f ),
            ( WeenieClassName.scimitar,         0.14f ),
            ( WeenieClassName.scimitaracid,     0.04f ),
            ( WeenieClassName.scimitarelectric, 0.04f ),
            ( WeenieClassName.scimitarfire,     0.04f ),
            ( WeenieClassName.scimitarfrost,    0.04f ),
            ( WeenieClassName.ken,              0.14f ),
            ( WeenieClassName.kenacid,          0.04f ),
            ( WeenieClassName.kenelectric,      0.04f ),
            ( WeenieClassName.kenfire,          0.04f ),
            ( WeenieClassName.kenfrost,         0.04f ),
            ( WeenieClassName.tachi,            0.14f ),
            ( WeenieClassName.tachiacid,        0.05f ),
            ( WeenieClassName.tachielectric,    0.05f ),
            ( WeenieClassName.tachifire,        0.05f ),
            ( WeenieClassName.tachifrost,       0.05f ),
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

        static SwordWcids_Sho()
        {
            if (Common.ConfigManager.Config.Server.WorldRuleset == Common.Ruleset.Infiltration)
            {
                T1_Chances = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.swordrapier,          0.05f ),
                    ( WeenieClassName.yaoji,                0.50f ),
                    ( WeenieClassName.scimitar,             0.15f ),
                    ( WeenieClassName.ken,                  0.15f ),
                    ( WeenieClassName.tachi,                0.15f ),
                };

                T1_T2_Chances = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.swordrapier,      0.125f ),

                    ( WeenieClassName.yaoji,             0.34f ),
                    ( WeenieClassName.yaojiacid,         0.02125f ),
                    ( WeenieClassName.yaojielectric,     0.02125f ),
                    ( WeenieClassName.yaojifire,         0.02125f ),
                    ( WeenieClassName.yaojifrost,        0.02125f ),

                    ( WeenieClassName.scimitar,          0.12f ),
                    ( WeenieClassName.scimitaracid,      0.0075f ),
                    ( WeenieClassName.scimitarelectric,  0.0075f ),
                    ( WeenieClassName.scimitarfire,      0.0075f ),
                    ( WeenieClassName.scimitarfrost,     0.0075f ),

                    ( WeenieClassName.ken,         0.12f ),
                    ( WeenieClassName.kenacid,     0.0075f ),
                    ( WeenieClassName.kenelectric, 0.0075f ),
                    ( WeenieClassName.kenfire,     0.0075f ),
                    ( WeenieClassName.kenfrost,    0.0075f ),

                    ( WeenieClassName.tachi,           0.12f ),
                    ( WeenieClassName.tachiacid,       0.0075f ),
                    ( WeenieClassName.tachielectric,   0.0075f ),
                    ( WeenieClassName.tachifire,       0.0075f ),
                    ( WeenieClassName.tachifrost,      0.0075f ),
                };

                T3_T4_Chances = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.swordrapier,      0.05f ),

                    ( WeenieClassName.yaoji,             0.1f ),
                    ( WeenieClassName.yaojiacid,         0.00625f ),
                    ( WeenieClassName.yaojielectric,     0.00625f ),
                    ( WeenieClassName.yaojifire,         0.00625f ),
                    ( WeenieClassName.yaojifrost,        0.00625f ),

                    ( WeenieClassName.scimitar,          0.22f ),
                    ( WeenieClassName.scimitaracid,      0.01375f ),
                    ( WeenieClassName.scimitarelectric,  0.01375f ),
                    ( WeenieClassName.scimitarfire,      0.01375f ),
                    ( WeenieClassName.scimitarfrost,     0.01375f ),

                    ( WeenieClassName.ken,         0.22f ),
                    ( WeenieClassName.kenacid,     0.01375f ),
                    ( WeenieClassName.kenelectric, 0.01375f ),
                    ( WeenieClassName.kenfire,     0.01375f ),
                    ( WeenieClassName.kenfrost,    0.01375f ),

                    ( WeenieClassName.tachi,           0.22f ),
                    ( WeenieClassName.tachiacid,       0.01375f ),
                    ( WeenieClassName.tachielectric,   0.01375f ),
                    ( WeenieClassName.tachifire,       0.01375f ),
                    ( WeenieClassName.tachifrost,      0.01375f ),
                };

                T5_T6_Chances = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.swordrapier,      0.03125f ),

                    ( WeenieClassName.yaoji,             0.025f ),
                    ( WeenieClassName.yaojiacid,         0.0015625f ),
                    ( WeenieClassName.yaojielectric,     0.0015625f ),
                    ( WeenieClassName.yaojifire,         0.0015625f ),
                    ( WeenieClassName.yaojifrost,        0.0015625f ),

                    ( WeenieClassName.scimitar,          0.25f ),
                    ( WeenieClassName.scimitaracid,      0.015625f ),
                    ( WeenieClassName.scimitarelectric,  0.015625f ),
                    ( WeenieClassName.scimitarfire,      0.015625f ),
                    ( WeenieClassName.scimitarfrost,     0.015625f ),

                    ( WeenieClassName.ken,         0.25f ),
                    ( WeenieClassName.kenacid,     0.015625f ),
                    ( WeenieClassName.kenelectric, 0.015625f ),
                    ( WeenieClassName.kenfire,     0.015625f ),
                    ( WeenieClassName.kenfrost,    0.015625f ),

                    ( WeenieClassName.tachi,           0.25f ),
                    ( WeenieClassName.tachiacid,       0.015625f ),
                    ( WeenieClassName.tachielectric,   0.015625f ),
                    ( WeenieClassName.tachifire,       0.015625f ),
                    ( WeenieClassName.tachifrost,      0.015625f ),
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
