using Module2HW6.Helper;

namespace Module2HW6.Models.Garment_Сare.Washer.Automatic
{
    public abstract class Automatic : Washer
    {
        public override WasherType WasherType { get; init; } = WasherType.Automatic;
        public override PriceSegment PriceSegment { get; init; } = PriceSegment.Expensive;
        public override bool HasMoreThanTwoModes { get; init; } = false;
    }
}