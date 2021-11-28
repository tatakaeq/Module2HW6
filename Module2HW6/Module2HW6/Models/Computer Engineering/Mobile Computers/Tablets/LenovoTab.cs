using Module2HW6.Helper;

namespace Module2HW6.Models.Computer_Engineering.Mobile_Computers.Tablets
{
    public class LenovoTab : Tablet
    {
        public override Size Size { get; init; } = Size.Small;
        public override double PowerConsumption { get; init; } = 0.5;
        public override string Brand { get; init; } = "Lenovo";
        public override EnergyEfficiencyType EfficiencyType { get; init; } = EnergyEfficiencyType.AAAA;
        public override PriceSegment PriceSegment { get; init; } = PriceSegment.Cheap;
        public override string Model { get; init; } = "ZA7S0052UA";
        public override MobileOsType MobileOsType { get; init; } = MobileOsType.Android;
        public override bool IsHaveStylusForDrawing { get; init; } = false;
    }
}