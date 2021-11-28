using Module2HW6.Helper;

namespace Module2HW6.Models.Garment_Сare.Washer
{
    public abstract class Washer : Appliances
    {
        public override Size Size { get; init; } = Size.Large;
        public override AppliancesType AppliancesType { get; init; } = AppliancesType.GarmentСare;
        public override EnergyEfficiencyType EfficiencyType { get; init; } = EnergyEfficiencyType.B;
        public override bool IsPortable { get; init; } = false;
        public override bool IsCompact { get; init; } = false;
        public abstract WasherType WasherType { get; init; }
        public abstract LoadingType LoadingType { get; init; }
        public abstract bool HasMoreThanTwoModes { get; init; }
    }
}