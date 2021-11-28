using Module2HW6.Helper;

namespace Module2HW6.Models.Garment_Сare.Washer.SemiAutomatic
{
    public abstract class SemiAutomatic : Washer
    {
        public override PriceSegment PriceSegment { get; init; } = PriceSegment.Medium;
        public override WasherType WasherType { get; init; } = WasherType.SemiAutomatic;
        public override bool HasMoreThanTwoModes { get; init; } = false;
    }
}