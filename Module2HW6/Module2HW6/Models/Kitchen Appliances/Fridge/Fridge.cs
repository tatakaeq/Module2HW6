using Module2HW6.Helper;

namespace Module2HW6.Models.Kitchen_Appliances.Fridge
{
    public abstract class Fridge : KitchenAppliances
    {
        public override Size Size { get; init; } = Size.Large;
        public override EnergyEfficiencyType EfficiencyType { get; init; } = EnergyEfficiencyType.AA;
        public override bool IsPortable { get; init; } = false;
        public override PriceSegment PriceSegment { get; init; } = PriceSegment.Expensive;
        public override bool IsCompact { get; init; } = false;

        public override KitchenAppliancesType KitchenAppliancesType { get; init; } =
            KitchenAppliancesType.PreservationOfProducts;
        public abstract CoolingSystemType CoolingSystemType { get; init; }
        public abstract FreezerLocation FreezerLocation { get; init; }
        public abstract InstallationType InstallationType { get; init; }
        public abstract bool HasDisplay { get; init; }
        public abstract bool HasMoreThanOneCompartment { get; init; }
    }
}