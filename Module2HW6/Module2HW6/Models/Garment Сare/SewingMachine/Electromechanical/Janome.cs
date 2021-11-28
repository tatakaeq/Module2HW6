using Module2HW6.Helper;

namespace Module2HW6.Models.Garment_Сare.SewingMachine.Electromechanical
{
    public class Janome : Electromechanical
    {
        public override double PowerConsumption { get; init; } = 5.0;
        public override string Brand { get; init; } = "JANOME";
        public override EnergyEfficiencyType EfficiencyType { get; init; } = EnergyEfficiencyType.A;
        public override PriceSegment PriceSegment { get; init; } = PriceSegment.Medium;
        public override string Model { get; init; } = "Dress Code";
        public override bool IsWithDisplay { get; init; } = false;
    }
}