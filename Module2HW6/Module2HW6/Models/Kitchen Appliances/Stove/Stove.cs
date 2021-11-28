using Module2HW6.Helper;

namespace Module2HW6.Models.Kitchen_Appliances.Stove
{
    public abstract class Stove : KitchenAppliances
    {
        public override EnergyEfficiencyType EfficiencyType { get; init; } = EnergyEfficiencyType.A;
        public override bool IsPortable { get; init; } = false;
        public override PriceSegment PriceSegment { get; init; } = PriceSegment.Expensive;
        public override bool IsCompact { get; init; } = false;
        public override KitchenAppliancesType KitchenAppliancesType { get; init; } =
            KitchenAppliancesType.HeatTreatment;
        public override Size Size { get; init; } = Size.Large;
        public abstract StoveType StoveType { get; init; }
        public abstract bool HasDisplay { get; init; }
        public abstract bool HasOven { get; init; }
    }
}