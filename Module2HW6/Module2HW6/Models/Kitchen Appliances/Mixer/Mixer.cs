using Module2HW6.Helper;

namespace Module2HW6.Models.Kitchen_Appliances.Mixer
{
    public abstract class Mixer : KitchenAppliances
    {
        public override Size Size { get; init; } = Size.Small;
        public override EnergyEfficiencyType EfficiencyType { get; init; } = EnergyEfficiencyType.AAA;
        public override bool IsPortable { get; init; } = true;
        public override PriceSegment PriceSegment { get; init; } = PriceSegment.Medium;

        public override KitchenAppliancesType KitchenAppliancesType { get; init; } =
            KitchenAppliancesType.MechanicalRestoration;
        public abstract MixerType MixerType { get; init; }
        public abstract bool CanWorkWithTightDough { get; init; }
    }
}