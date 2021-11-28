using Module2HW6.Helper;

namespace Module2HW6.Models.Kitchen_Appliances.Stove
{
    public class GorenjeE : Stove
    {
        public override double PowerConsumption { get; init; } = 65.0;
        public override string Brand { get; init; } = "Gorenje";
        public override string Model { get; init; } = "5121WH";
        public override StoveType StoveType { get; init; } = StoveType.Electrical;
        public override bool HasDisplay { get; init; } = false;
        public override bool HasOven { get; init; } = true;
    }
}