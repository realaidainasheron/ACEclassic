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
            if (Common.ConfigManager.Config.Server.WorldRuleset <= Common.Ruleset.Infiltration)
            {
                T3_Chances = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.orb,                    0.18f ),
                    ( WeenieClassName.sceptre,                0.18f ),
                    ( WeenieClassName.staff,                  0.18f ),
                    ( WeenieClassName.wand,                   0.18f ),
                    ( WeenieClassName.wandslashing,           0.04f ),
                    ( WeenieClassName.wandpiercing,           0.04f ),
                    ( WeenieClassName.wandblunt,              0.04f ),
                    ( WeenieClassName.wandacid,               0.04f ),
                    ( WeenieClassName.wandfire,               0.04f ),
                    ( WeenieClassName.wandfrost,              0.04f ),
                    ( WeenieClassName.wandelectric,           0.04f ),
                };

                T4_Chances = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.orb,                    0.145f ),
                    ( WeenieClassName.sceptre,                0.145f ),
                    ( WeenieClassName.staff,                  0.145f ),
                    ( WeenieClassName.wand,                   0.145f ),
                    ( WeenieClassName.wandslashing,           0.06f ),
                    ( WeenieClassName.wandpiercing,           0.06f ),
                    ( WeenieClassName.wandblunt,              0.06f ),
                    ( WeenieClassName.wandacid,               0.06f ),
                    ( WeenieClassName.wandfire,               0.06f ),
                    ( WeenieClassName.wandfrost,              0.06f ),
                    ( WeenieClassName.wandelectric,           0.06f ),
                };

                T5_T6_Chances = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.orb,                    0.09f ),
                    ( WeenieClassName.sceptre,                0.09f ),
                    ( WeenieClassName.staff,                  0.09f ),
                    ( WeenieClassName.wand,                   0.10f ),

                    ( WeenieClassName.wandslashing,           0.09f ),
                    ( WeenieClassName.wandpiercing,           0.09f ),
                    ( WeenieClassName.wandblunt,              0.09f ),
                    ( WeenieClassName.wandacid,               0.09f ),
                    ( WeenieClassName.wandfire,               0.09f ),
                    ( WeenieClassName.wandfrost,              0.09f ),
                    ( WeenieClassName.wandelectric,           0.09f ),
                };

                T7_Chances = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.orb,                    0.07f ),
                    ( WeenieClassName.sceptre,                0.07f ),
                    ( WeenieClassName.staff,                  0.08f ),
                    ( WeenieClassName.wand,                   0.08f ),

                    ( WeenieClassName.wandslashing,           0.10f ),
                    ( WeenieClassName.wandpiercing,           0.10f ),
                    ( WeenieClassName.wandblunt,              0.10f ),
                    ( WeenieClassName.wandacid,               0.10f ),
                    ( WeenieClassName.wandfire,               0.10f ),
                    ( WeenieClassName.wandfrost,              0.10f ),
                    ( WeenieClassName.wandelectric,           0.10f ),
                };

                T8_Chances = new ChanceTable<WeenieClassName>()
                {
                    ( WeenieClassName.orb,                    0.05f ),
                    ( WeenieClassName.sceptre,                0.06f ),
                    ( WeenieClassName.staff,                  0.06f ),
                    ( WeenieClassName.wand,                   0.06f ),

                    ( WeenieClassName.wandslashing,           0.11f ),
                    ( WeenieClassName.wandpiercing,           0.11f ),
                    ( WeenieClassName.wandblunt,              0.11f ),
                    ( WeenieClassName.wandacid,               0.11f ),
                    ( WeenieClassName.wandfire,               0.11f ),
                    ( WeenieClassName.wandfrost,              0.11f ),
                    ( WeenieClassName.wandelectric,           0.11f ),
                };
                
                // we have to refresh this list or it will still contain the previous values.
                casterTiers = new List<ChanceTable<WeenieClassName>>()
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
            }
        }

        public static WeenieClassName Roll(int tier)
        {
            return casterTiers[tier - 1].Roll();
        }
    }
}
