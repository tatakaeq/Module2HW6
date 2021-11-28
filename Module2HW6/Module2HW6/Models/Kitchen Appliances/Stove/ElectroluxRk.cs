using Module2HW6.Helper;

namespace Module2HW6.Models.Kitchen_Appliances.Stove
{
    public class ElectroluxRk : Stove
    {
        public override double PowerConsumption { get; init; } = 80.0;
        public override string Brand { get; init; } = "Electrolux";
        public override string Model { get; init; } = "R560100W";
        public override StoveType StoveType { get; init; } = StoveType.GlassCeramic;
        public override bool HasDisplay { get; init; } = false;
        public override bool HasOven { get; init; } = true;
    }
}