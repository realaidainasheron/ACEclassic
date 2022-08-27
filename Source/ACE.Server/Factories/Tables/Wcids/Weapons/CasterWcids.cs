using System;
using System.Collections.Generic;
using ACE.Database.Models.World;
using ACE.Server.Factories.Entity;
using ACE.Server.Factories.Enum;

namespace ACE.Server.Factories.Tables.Wcids
{
    public static class CasterWcids
    {
        private static ChanceTable<WeenieClassName> T1_T2_Chances = new ChanceTable<WeenieClassName>()
        {
            (WeenieClassName.orb,     0.25f ),
            (WeenieClassName.sceptre, 0.25f ),
            (WeenieClassName.staff,   0.25f ),
            (WeenieClassName.wand,    0.25f ),
        };

        private static ChanceTable<WeenieClassName> T3_Chances = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.orb,                    0.17f ),
            ( WeenieClassName.sceptre,                0.17f ),
            ( WeenieClassName.staff,                  0.17f ),
            ( WeenieClassName.wand,                   0.17f ),
            ( WeenieClassName.wandslashing,           0.02f ),
            ( WeenieClassName.wandpiercing,           0.02f ),
            ( WeenieClassName.wandblunt,              0.02f ),
            ( WeenieClassName.wandacid,               0.02f ),
            ( WeenieClassName.wandfire,               0.02f ),
            ( WeenieClassName.wandfrost,              0.02f ),
            ( WeenieClassName.wandelectric,           0.02f ),
            ( WeenieClassName.ace43381_nethersceptre, 0.02f ),
            ( WeenieClassName.ace31819_slashingbaton, 0.02f ),
            ( WeenieClassName.ace31825_piercingbaton, 0.02f ),
            ( WeenieClassName.ace31821_bluntbaton,    0.02f ),
            ( WeenieClassName.ace31820_acidbaton,     0.02f ),
            ( WeenieClassName.ace31823_firebaton,     0.02f ),
            ( WeenieClassName.ace31824_frostbaton,    0.02f ),
            ( WeenieClassName.ace31822_electricbaton, 0.02f ),
            ( WeenieClassName.ace43382_netherbaton,   0.02f ),
        };

        private static ChanceTable<WeenieClassName> T4_Chances = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.orb,                    0.13f ),
            ( WeenieClassName.sceptre,                0.13f ),
            ( WeenieClassName.staff,                  0.13f ),
            ( WeenieClassName.wand,                   0.13f ),
            ( WeenieClassName.wandslashing,           0.03f ),
            ( WeenieClassName.wandpiercing,           0.03f ),
            ( WeenieClassName.wandblunt,              0.03f ),
            ( WeenieClassName.wandacid,               0.03f ),
            ( WeenieClassName.wandfire,               0.03f ),
            ( WeenieClassName.wandfrost,              0.03f ),
            ( WeenieClassName.wandelectric,           0.03f ),
            ( WeenieClassName.ace43381_nethersceptre, 0.03f ),
            ( WeenieClassName.ace31819_slashingbaton, 0.03f ),
            ( WeenieClassName.ace31825_piercingbaton, 0.03f ),
            ( WeenieClassName.ace31821_bluntbaton,    0.03f ),
            ( WeenieClassName.ace31820_acidbaton,     0.03f ),
            ( WeenieClassName.ace31823_firebaton,     0.03f ),
            ( WeenieClassName.ace31824_frostbaton,    0.03f ),
            ( WeenieClassName.ace31822_electricbaton, 0.03f ),
            ( WeenieClassName.ace43382_netherbaton,   0.03f ),
        };

        private static ChanceTable<WeenieClassName> T5_T6_Chances = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.orb,                    0.05f ),
            ( WeenieClassName.sceptre,                0.05f ),
            ( WeenieClassName.staff,                  0.05f ),
            ( WeenieClassName.wand,                   0.05f ),
            ( WeenieClassName.wandslashing,           0.05f ),
            ( WeenieClassName.wandpiercing,           0.05f ),
            ( WeenieClassName.wandblunt,              0.05f ),
            ( WeenieClassName.wandacid,               0.05f ),
            ( WeenieClassName.wandfire,               0.05f ),
            ( WeenieClassName.wandfrost,              0.05f ),
            ( WeenieClassName.wandelectric,           0.05f ),
            ( WeenieClassName.ace43381_nethersceptre, 0.05f ),
            ( WeenieClassName.ace31819_slashingbaton, 0.05f ),
            ( WeenieClassName.ace31825_piercingbaton, 0.05f ),
            ( WeenieClassName.ace31821_bluntbaton,    0.05f ),
            ( WeenieClassName.ace31820_acidbaton,     0.05f ),
            ( WeenieClassName.ace31823_firebaton,     0.05f ),
            ( WeenieClassName.ace31824_frostbaton,    0.05f ),
            ( WeenieClassName.ace31822_electricbaton, 0.05f ),
            ( WeenieClassName.ace43382_netherbaton,   0.05f ),
        };

        private static ChanceTable<WeenieClassName> T7_Chances = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.orb,                    0.04f ),
            ( WeenieClassName.sceptre,                0.04f ),
            ( WeenieClassName.staff,                  0.04f ),
            ( WeenieClassName.wand,                   0.04f ),
            ( WeenieClassName.wandslashing,           0.045f ),
            ( WeenieClassName.wandpiercing,           0.045f ),
            ( WeenieClassName.wandblunt,              0.045f ),
            ( WeenieClassName.wandacid,               0.045f ),
            ( WeenieClassName.wandfire,               0.045f ),
            ( WeenieClassName.wandfrost,              0.045f ),
            ( WeenieClassName.wandelectric,           0.045f ),
            ( WeenieClassName.ace43381_nethersceptre, 0.045f ),
            ( WeenieClassName.ace31819_slashingbaton, 0.045f ),
            ( WeenieClassName.ace31825_piercingbaton, 0.045f ),
            ( WeenieClassName.ace31821_bluntbaton,    0.045f ),
            ( WeenieClassName.ace31820_acidbaton,     0.045f ),
            ( WeenieClassName.ace31823_firebaton,     0.045f ),
            ( WeenieClassName.ace31824_frostbaton,    0.045f ),
            ( WeenieClassName.ace31822_electricbaton, 0.045f ),
            ( WeenieClassName.ace43382_netherbaton,   0.045f ),
            ( WeenieClassName.ace37223_slashingstaff, 0.015f ),
            ( WeenieClassName.ace37222_piercingstaff, 0.015f ),
            ( WeenieClassName.ace37225_bluntstaff,    0.015f ),
            ( WeenieClassName.ace37224_acidstaff,     0.015f ),
            ( WeenieClassName.ace37220_firestaff,     0.015f ),
            ( WeenieClassName.ace37221_froststaff,    0.015f ),
            ( WeenieClassName.ace37219_electricstaff, 0.015f ),
            ( WeenieClassName.ace43383_netherstaff,   0.015f ),
        };

        private static ChanceTable<WeenieClassName> T8_Chances = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.orb,                    0.036f ),
            ( WeenieClassName.sceptre,                0.036f ),
            ( WeenieClassName.staff,                  0.036f ),
            ( WeenieClassName.wand,                   0.036f ),
            ( WeenieClassName.wandslashing,           0.036f ),
            ( WeenieClassName.wandpiercing,           0.036f ),
            ( WeenieClassName.wandblunt,              0.036f ),
            ( WeenieClassName.wandacid,               0.036f ),
            ( WeenieClassName.wandfire,               0.036f ),
            ( WeenieClassName.wandfrost,              0.036f ),
            ( WeenieClassName.wandelectric,           0.036f ),
            ( WeenieClassName.ace43381_nethersceptre, 0.036f ),
            ( WeenieClassName.ace31819_slashingbaton, 0.036f ),
            ( WeenieClassName.ace31825_piercingbaton, 0.036f ),
            ( WeenieClassName.ace31821_bluntbaton,    0.036f ),
            ( WeenieClassName.ace31820_acidbaton,     0.036f ),
            ( WeenieClassName.ace31823_firebaton,     0.036f ),
            ( WeenieClassName.ace31824_frostbaton,    0.036f ),
            ( WeenieClassName.ace31822_electricbaton, 0.036f ),
            ( WeenieClassName.ace43382_netherbaton,   0.036f ),
            ( WeenieClassName.ace37223_slashingstaff, 0.035f ),
            ( WeenieClassName.ace37222_piercingstaff, 0.035f ),
            ( WeenieClassName.ace37225_bluntstaff,    0.035f ),
            ( WeenieClassName.ace37224_acidstaff,     0.035f ),
            ( WeenieClassName.ace37220_firestaff,     0.035f ),
            ( WeenieClassName.ace37221_froststaff,    0.035f ),
            ( WeenieClassName.ace37219_electricstaff, 0.035f ),
            ( WeenieClassName.ace43383_netherstaff,   0.035f ),
        };

        private static readonly List<ChanceTable<WeenieClassName>> casterTiers = new List<ChanceTable<WeenieClassName>>()
        {
            T1_T2_Chances,
            T1_T2_Chances,
            T3_Chances,
            T4_Chances,
            T5_T6_Chances,
            T5_T6_Chances,
            T7_Chances,
            T8_Chances
        };
        static CasterWcids()
        {
            if (Common.ConfigManager.Config.Server.WorldRuleset == Common.Ruleset.Infiltration)
            {
                T1_T2_Chances = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    (WeenieClassName.orb,     1.0f ),
                    (WeenieClassName.sceptre, 1.0f ),
                    (WeenieClassName.staff,   1.0f ),
                    (WeenieClassName.wand,    1.0f ),
                };

                T3_Chances = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.orb,                    4.0f ),
                    ( WeenieClassName.sceptre,                4.0f ),
                    ( WeenieClassName.staff,                  4.0f ),
                    ( WeenieClassName.wand,                   4.0f ),

                    ( WeenieClassName.wandslashing,           1.0f ),
                    ( WeenieClassName.wandpiercing,           1.0f ),
                    ( WeenieClassName.wandblunt,              1.0f ),
                    ( WeenieClassName.wandacid,               1.0f ),
                    ( WeenieClassName.wandfire,               1.0f ),
                    ( WeenieClassName.wandfrost,              1.0f ),
                    ( WeenieClassName.wandelectric,           1.0f ),
                };

                T5_T6_Chances = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.orb,                    1.0f ),
                    ( WeenieClassName.sceptre,                1.0f ),
                    ( WeenieClassName.staff,                  1.0f ),
                    ( WeenieClassName.wand,                   1.0f ),

                    ( WeenieClassName.wandslashing,           1.0f ),
                    ( WeenieClassName.wandpiercing,           1.0f ),
                    ( WeenieClassName.wandblunt,              1.0f ),
                    ( WeenieClassName.wandacid,               1.0f ),
                    ( WeenieClassName.wandfire,               1.0f ),
                    ( WeenieClassName.wandfrost,              1.0f ),
                    ( WeenieClassName.wandelectric,           1.0f ),
                };
                
                // we have to refresh this list or it will still contain the previous values.
                casterTiers = new List<ChanceTable<WeenieClassName>>()
		        {
		            T1_T2_Chances,
		            T1_T2_Chances,
		            T3_Chances,
                    T3_Chances,
		            T5_T6_Chances,
                    T5_T6_Chances,
                    T5_T6_Chances,
                    T5_T6_Chances
                };
            }
            else if (Common.ConfigManager.Config.Server.WorldRuleset == Common.Ruleset.CustomDM)
            {
                T1_T2_Chances = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    (WeenieClassName.orb,     1.0f ),
                    (WeenieClassName.sceptre, 1.0f ),
                    (WeenieClassName.staff,   1.0f ),
                    (WeenieClassName.wand,    1.0f ),
                };

                T3_Chances = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.orb,                   16.0f ),
                    ( WeenieClassName.sceptre,               16.0f ),
                    ( WeenieClassName.staff,                 16.0f ),
                    ( WeenieClassName.wand,                  16.0f ),

                    ( WeenieClassName.wandslashing,           1.0f ),
                    ( WeenieClassName.wandpiercing,           1.0f ),
                    ( WeenieClassName.wandblunt,              1.0f ),
                    ( WeenieClassName.wandacid,               1.0f ),
                    ( WeenieClassName.wandfire,               1.0f ),
                    ( WeenieClassName.wandfrost,              1.0f ),
                    ( WeenieClassName.wandelectric,           1.0f ),
                };

                T5_T6_Chances = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.orb,                    1.0f ),
                    ( WeenieClassName.sceptre,                1.0f ),
                    ( WeenieClassName.staff,                  1.0f ),
                    ( WeenieClassName.wand,                   1.0f ),

                    ( WeenieClassName.wandslashing,           1.0f ),
                    ( WeenieClassName.wandpiercing,           1.0f ),
                    ( WeenieClassName.wandblunt,              1.0f ),
                    ( WeenieClassName.wandacid,               1.0f ),
                    ( WeenieClassName.wandfire,               1.0f ),
                    ( WeenieClassName.wandfrost,              1.0f ),
                    ( WeenieClassName.wandelectric,           1.0f ),
                };

                // we have to refresh this list or it will still contain the previous values.
                casterTiers = new List<ChanceTable<WeenieClassName>>()
                {
                    T1_T2_Chances,
                    T1_T2_Chances,
                    T3_Chances,
                    T3_Chances,
                    T5_T6_Chances,
                    T5_T6_Chances,
                    T5_T6_Chances,
                    T5_T6_Chances
                };
            }

            foreach (var casterTier in casterTiers)
            {
                foreach (var entry in casterTier)
                    _combined.Add(entry.result);
            }
        }

        public static WeenieClassName Roll(int tier)
        {
            return casterTiers[tier - 1].Roll();
        }

        private static readonly HashSet<WeenieClassName> _combined = new HashSet<WeenieClassName>();

        public static bool Contains(WeenieClassName wcid)
        {
            return _combined.Contains(wcid);
        }
    }
}
