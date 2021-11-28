using Module2HW6.Helper;

namespace Module2HW6.Models.Computer_Engineering.Wearable_Micro_Computers.SmartRing
{
    public class Jakcom : SmartRing
    {
        public override Size Size { get; init; } = Size.Small;
        public override double PowerConsumption { get; init; } = 0.001;
        public override string Brand { get; init; } = "Jakcom";
        public override PriceSegment PriceSegment { get; init; } = PriceSegment.Cheap;
        public override string Model { get; init; } = "R3";
        public override bool IsHaveEsim { get; init; } = true;
        public override bool IsAutonomous { get; init; } = false;
        public override bool IsNeedsSmartPhone { get; init; } = true;
        public override bool HasNfc { get; init; } = true;
    }
}