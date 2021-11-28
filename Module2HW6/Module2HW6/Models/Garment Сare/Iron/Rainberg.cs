using Module2HW6.Helper;

namespace Module2HW6.Models.Garment_Сare.Iron
{
    public class Rainberg : Iron
    {
        public override double PowerConsumption { get; init; } = 5.0;
        public override string Brand { get; init; } = "Rainberg";
        public override EnergyEfficiencyType EfficiencyType { get; init; } = EnergyEfficiencyType.AAAA;
        public override PriceSegment PriceSegment { get; init; } = PriceSegment.Cheap;
        public override string Model { get; init; } = "RB-6311";
        public override IronType IronType { get; init; } = IronType.Simple;
    }
}