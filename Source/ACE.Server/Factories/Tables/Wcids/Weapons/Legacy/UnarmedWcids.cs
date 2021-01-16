using ACE.Server.Factories.Entity;
using ACE.Server.Factories.Enum;

using WeenieClassName = ACE.Server.Factories.Enum.WeenieClassName;

namespace ACE.Server.Factories.Tables.Wcids
{
    public static class UnarmedWcids
    {
        private static ChanceTable<WeenieClassName> UnarmedWcids_Aluvian_Tier1;
        private static ChanceTable<WeenieClassName> UnarmedWcids_Aluvian = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.cestus,         0.40f ),
            ( WeenieClassName.cestusacid,     0.15f ),
            ( WeenieClassName.cestuselectric, 0.15f ),
            ( WeenieClassName.cestusfire,     0.15f ),
            ( WeenieClassName.cestusfrost,    0.15f ),
        };

        private static ChanceTable<WeenieClassName> UnarmedWcids_Gharundim_Tier1;
        private static ChanceTable<WeenieClassName> UnarmedWcids_Gharundim = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.katar,         0.40f ),
            ( WeenieClassName.kataracid,     0.15f ),
            ( WeenieClassName.katarelectric, 0.15f ),
            ( WeenieClassName.katarfire,     0.15f ),
            ( WeenieClassName.katarfrost,    0.15f ),
        };

        private static ChanceTable<WeenieClassName> UnarmedWcids_Sho_Tier1;
        private static ChanceTable<WeenieClassName> UnarmedWcids_Sho = new ChanceTable<WeenieClassName>()
        {
            ( WeenieClassName.nekode,         0.40f ),
            ( WeenieClassName.nekodeacid,     0.15f ),
            ( WeenieClassName.nekodeelectric, 0.15f ),
            ( WeenieClassName.nekodefire,     0.15f ),
            ( WeenieClassName.nekodefrost,    0.15f ),
        };
        static UnarmedWcids()
        {
            if (Common.ConfigManager.Config.Server.WorldRuleset <= Common.Ruleset.Infiltration)
            {
                UnarmedWcids_Aluvian_Tier1 = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.cestus,         1.00f ),
                };

                UnarmedWcids_Aluvian = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.cestus,         4.00f ),
                    ( WeenieClassName.cestusacid,     0.25f ),
                    ( WeenieClassName.cestuselectric, 0.25f ),
                    ( WeenieClassName.cestusfire,     0.25f ),
                    ( WeenieClassName.cestusfrost,    0.25f ),
                };

                UnarmedWcids_Gharundim_Tier1 = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.katar,         1.00f ),
                };

                UnarmedWcids_Gharundim = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.katar,         4.00f ),
                    ( WeenieClassName.kataracid,     0.25f ),
                    ( WeenieClassName.katarelectric, 0.25f ),
                    ( WeenieClassName.katarfire,     0.25f ),
                    ( WeenieClassName.katarfrost,    0.25f ),
                };

                UnarmedWcids_Sho_Tier1 = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.nekode,         1.00f ),
                };

                UnarmedWcids_Sho = new ChanceTable<WeenieClassName>(ChanceTableType.Weight)
                {
                    ( WeenieClassName.nekode,         4.00f ),
                    ( WeenieClassName.nekodeacid,     0.25f ),
                    ( WeenieClassName.nekodeelectric, 0.25f ),
                    ( WeenieClassName.nekodefire,     0.25f ),
                    ( WeenieClassName.nekodefrost,    0.25f ),
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
                        return UnarmedWcids_Aluvian_Tier1.Roll();

                    case TreasureHeritageGroup.Gharundim:
                        if (tier > 1)
                            return UnarmedWcids_Gharundim.Roll();
                        return UnarmedWcids_Gharundim_Tier1.Roll();

                    case TreasureHeritageGroup.Sho:
                        if (tier > 1)
                            return UnarmedWcids_Sho.Roll();
                        return UnarmedWcids_Sho_Tier1.Roll();
                }
            }
            return WeenieClassName.undef;
        }
    }
}
