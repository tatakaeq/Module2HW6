using Module2HW6.Helper;

namespace Module2HW6.Models.Computer_Engineering.Mobile_Computers.Smartphones
{
    public class SamsungGalaxy : Smartphone
    {
        public override Size Size { get; init; } = Size.Small;
        public override double PowerConsumption { get; init; } = 0.1;
        public override string Brand { get; init; } = "Samsung";
        public override EnergyEfficiencyType EfficiencyType { get; init; } = EnergyEfficiencyType.AAAA;
        public override PriceSegment PriceSegment { get; init; } = PriceSegment.Medium;
        public override string Model { get; init; } = "S20FE";
        public override MobileOsType MobileOsType { get; init; } = MobileOsType.Android;
        public override bool IsHaveMoreThanOneCamera { get; init; } = true;
    }
}