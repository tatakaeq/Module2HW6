using Module2HW6.Helper;

namespace Module2HW6.Models.Computer_Engineering.Mobile_Computers.Laptops
{
    public class AppleMacBookAir : Laptop
    {
        public override Size Size { get; init; } = Size.Medium;
        public override double PowerConsumption { get; init; } = 1.0;
        public override string Brand { get; init; } = "Apple";
        public override EnergyEfficiencyType EfficiencyType { get; init; } = EnergyEfficiencyType.AAAA;
        public override PriceSegment PriceSegment { get; init; } = PriceSegment.Expensive;
        public override string Model { get; init; } = "MGN63";
        public override bool IsGoodForGaming { get; init; } = false;
        public override OsType OsType { get; init; } = OsType.Mac;
        public override bool IsHaveANumPad { get; init; } = false;
    }
}