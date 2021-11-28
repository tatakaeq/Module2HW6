using Module2HW6.Helper;

namespace Module2HW6.Models.Computer_Engineering.Personal_Computers.Monoblock
{
    public class AppleiMac : Monoblock
    {
        public override double PowerConsumption { get; init; } = 1.0;
        public override string Brand { get; init; } = "Apple";
        public override PriceSegment PriceSegment { get; init; } = PriceSegment.Expensive;
        public override string Model { get; init; } = "М14.5К";
        public override bool IsGoodForGaming { get; init; } = false;
        public override OsType OsType { get; init; } = OsType.Mac;
    }
}