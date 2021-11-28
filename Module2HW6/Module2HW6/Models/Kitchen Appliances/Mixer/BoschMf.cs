using Module2HW6.Helper;

namespace Module2HW6.Models.Kitchen_Appliances.Mixer
{
    public class BoschMf : Mixer
    {
        public override double PowerConsumption { get; init; } = 23.0;
        public override string Brand { get; init; } = "Bosch";
        public override string Model { get; init; } = "Q3540";
        public override bool IsCompact { get; init; } = true;
        public override MixerType MixerType { get; init; } = MixerType.Hand;
        public override bool CanWorkWithTightDough { get; init; } = false;
    }
}