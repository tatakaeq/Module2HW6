using Module2HW6.Helper;

namespace Module2HW6.Models.Garment_Сare.Iron
{
    public abstract class Iron : GarmentСare
    {
        public override Size Size { get; init; } = Size.Small;
        public override bool IsCompact { get; init; } = true;
        public override GarmentСareType GarmentСareType { get; init; } = GarmentСareType.Iron;
        public override bool IsPortable { get; init; } = true;
        public abstract IronType IronType { get; init; }
    }
}