using Module2HW6.Helper;

namespace Module2HW6.Models.Computer_Engineering.Mobile_Computers.Tablets
{
    public class AppleIPad : Tablet
    {
        public override Size Size { get; init; } = Size.Small;
        public override double PowerConsumption { get; init; } = 0.2;
        public override string Brand { get; init; } = "Apple";
        public override EnergyEfficiencyType EfficiencyType { get; init; } = EnergyEfficiencyType.AAAA;
        public override PriceSegment PriceSegment { get; init; } = PriceSegment.Expensive;
        public override string Model { get; init; } = "MYFN2RK/A";
        public override MobileOsType MobileOsType { get; init; } = MobileOsType.Ios;
        public override bool IsHaveStylusForDrawing { get; init; } = true;
    }
}