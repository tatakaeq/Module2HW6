using Module2HW6.Helper;

namespace Module2HW6.Models.Kitchen_Appliances.Mixer
{
    public class BoschMfq : Mixer
    {
        public override double PowerConsumption { get; init; } = 40.0;
        public override string Brand { get; init; } = "Bosch";
        public override string Model { get; init; } = "36490";
        public override bool IsCompact { get; init; } = false;
        public override MixerType MixerType { get; init; } = MixerType.Stationary;
        public override bool CanWorkWithTightDough { get; init; } = true;
    }
}