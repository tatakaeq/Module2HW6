using Module2HW6.Helper;

namespace Module2HW6.Models
{
    public abstract class Appliances
    {
        public abstract Size Size { get; init; }
        public abstract AppliancesType AppliancesType { get; init; }
        public abstract double PowerConsumption { get; init; }
        public abstract string Brand { get; init; }
        public abstract EnergyEfficiencyType EfficiencyType { get; init; }
        public abstract bool IsPortable { get; init; }
        public abstract PriceSegment PriceSegment { get; init; }
        public abstract string Model { get; init; }
        public abstract bool IsCompact { get; init; }
    }
}