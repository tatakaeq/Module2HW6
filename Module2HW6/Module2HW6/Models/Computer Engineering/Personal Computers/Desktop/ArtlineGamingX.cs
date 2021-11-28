using Module2HW6.Helper;

namespace Module2HW6.Models.Computer_Engineering.Personal_Computers.Desktop
{
    public class ArtlineGamingX : Desktop
    {
        public override double PowerConsumption { get; init; } = 1.5;
        public override string Brand { get; init; } = "Artline";
        public override EnergyEfficiencyType EfficiencyType { get; init; } = EnergyEfficiencyType.A;
        public override PriceSegment PriceSegment { get; init; } = PriceSegment.Expensive;
        public override string Model { get; init; } = "X39v42";
        public override bool IsGoodForGaming { get; init; } = true;
        public override OsType OsType { get; init; } = OsType.Windows;
    }
}