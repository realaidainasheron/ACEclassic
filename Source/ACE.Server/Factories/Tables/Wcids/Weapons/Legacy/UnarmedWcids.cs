using ACE.Server.Factories.Entity;
using ACE.Server.Factories.Enum;

using WeenieClassName = ACE.Server.Factories.Enum.WeenieClassName;

namespace ACE.Server.Factories.Tables.Wcids
{
    public static class UnarmedWcids
    {
        private static ChanceTable<WeenieClassName> UnarmedWcids_Aluvian_Non_Elemental = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.cestus,         1.00f ),
        };

        private static ChanceTable<WeenieClassName> UnarmedWcids_Aluvian = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.cestus,         0.40f ),
            ( WeenieClassName.cestusacid,     0.15f ),
            ( WeenieClassName.cestuselectric, 0.15f ),
            ( WeenieClassName.cestusfire,     0.15f ),
            ( WeenieClassName.cestusfrost,    0.15f ),
        };

        private static ChanceTable<WeenieClassName> UnarmedWcids_Gharundim_Non_Elemental = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.katar,         1.00f ),
        };

        private static ChanceTable<WeenieClassName> UnarmedWcids_Gharundim = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.katar,         0.40f ),
            ( WeenieClassName.kataracid,     0.15f ),
            ( WeenieClassName.katarelectric, 0.15f ),
            ( WeenieClassName.katarfire,     0.15f ),
            ( WeenieClassName.katarfrost,    0.15f ),
        };

        private static ChanceTable<WeenieClassName> UnarmedWcids_Sho_Non_Elemental = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.nekode,         1.00f ),
        };

        private static ChanceTable<WeenieClassName> UnarmedWcids_Sho = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.nekode,         0.40f ),
            ( WeenieClassName.nekodeacid,     0.15f ),
            ( WeenieClassName.nekodeelectric, 0.15f ),
            ( WeenieClassName.nekodefire,     0.15f ),
            ( WeenieClassName.nekodefrost,    0.15f ),
        };

        public static WeenieClassName Roll(TreasureHeritageGroup heritage, int tier)
        {
            if (Common.ConfigManager.Config.Server.WorldRuleset == Common.Ruleset.EoR)
            {
                switch (heritage)
                {
                    case TreasureHeritageGroup.Aluvian:
                        return UnarmedWcids_Aluvian.Roll();

                    case TreasureHeritageGroup.Gharundim:
                        return UnarmedWcids_Gharundim.Roll();

                    case TreasureHeritageGroup.Sho:
                        return UnarmedWcids_Sho.Roll();
                }
            }
            else
            {
                switch (heritage)
                {
                    case TreasureHeritageGroup.Aluvian:
                        if (tier > 1)
                            return UnarmedWcids_Aluvian.Roll();
                        return UnarmedWcids_Aluvian_Non_Elemental.Roll();

                    case TreasureHeritageGroup.Gharundim:
                        if (tier > 1)
                            return UnarmedWcids_Gharundim.Roll();
                        return UnarmedWcids_Gharundim_Non_Elemental.Roll();

                    case TreasureHeritageGroup.Sho:
                        if (tier > 1)
                            return UnarmedWcids_Sho.Roll();
                        return UnarmedWcids_Sho_Non_Elemental.Roll();
                }
            }
            return WeenieClassName.undef;
        }
    }
}
