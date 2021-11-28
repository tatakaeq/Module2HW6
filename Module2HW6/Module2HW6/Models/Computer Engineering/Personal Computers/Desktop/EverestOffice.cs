using Module2HW6.Helper;

namespace Module2HW6.Models.Computer_Engineering.Personal_Computers.Desktop
{
    public class EverestOffice : Desktop
    {
        public override double PowerConsumption { get; init; } = 1.0;
        public override string Brand { get; init; } = "Everest";
        public override EnergyEfficiencyType EfficiencyType { get; init; } = EnergyEfficiencyType.B;
        public override PriceSegment PriceSegment { get; init; } = PriceSegment.Cheap;
        public override string Model { get; init; } = "1041";
        public override bool IsGoodForGaming { get; init; } = false;
        public override OsType OsType { get; init; } = OsType.Windows;
    }
}