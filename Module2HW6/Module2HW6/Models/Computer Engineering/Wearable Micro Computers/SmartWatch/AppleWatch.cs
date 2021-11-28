using Module2HW6.Helper;

namespace Module2HW6.Models.Computer_Engineering.Wearable_Micro_Computers.SmartWatch
{
    public class AppleWatch : SmartWatch
    {
        public override Size Size { get; init; } = Size.Small;
        public override double PowerConsumption { get; init; } = 0.1;
        public override string Brand { get; init; } = "Apple";
        public override PriceSegment PriceSegment { get; init; } = PriceSegment.Medium;
        public override string Model { get; init; } = "Series 7";
        public override bool IsHaveEsim { get; init; } = true;
        public override bool IsHaveGps { get; init; } = true;
    }
}