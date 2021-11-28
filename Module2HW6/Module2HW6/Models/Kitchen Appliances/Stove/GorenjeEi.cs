using Module2HW6.Helper;

namespace Module2HW6.Models.Kitchen_Appliances.Stove
{
    public class GorenjeEi : Stove
    {
        public override double PowerConsumption { get; init; } = 77.0;
        public override string Brand { get; init; } = "Gorenje";
        public override string Model { get; init; } = "T5355XPG";
        public override StoveType StoveType { get; init; } = StoveType.Induction;
        public override bool HasDisplay { get; init; } = true;
        public override bool HasOven { get; init; } = true;
    }
}