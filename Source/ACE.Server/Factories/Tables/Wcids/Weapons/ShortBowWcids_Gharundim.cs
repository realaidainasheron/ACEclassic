using System;
using System.Collections.Generic;

using ACE.Server.Factories.Entity;
using ACE.Server.Factories.Enum;

namespace ACE.Server.Factories.Tables.Wcids
{
    public static class ShortBowWcids_Gharundim
    {
        private static ChanceTable<WeenieClassName> Chances = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.yag,      1.0f ),
        };

        public static WeenieClassName Roll(int tier)
        {
            return Chances.Roll();
        }
    }
}
