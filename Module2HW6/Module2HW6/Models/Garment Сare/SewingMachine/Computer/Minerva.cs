using Module2HW6.Helper;

namespace Module2HW6.Models.Garment_Сare.SewingMachine.Computer
{
    public class Minerva : Computer
    {
        public override double PowerConsumption { get; init; } = 10.0;
        public override string Brand { get; init; } = "MINERVA";
        public override EnergyEfficiencyType EfficiencyType { get; init; } = EnergyEfficiencyType.A;
        public override PriceSegment PriceSegment { get; init; } = PriceSegment.Expensive;
        public override string Model { get; init; } = "MC90С";
    }
}