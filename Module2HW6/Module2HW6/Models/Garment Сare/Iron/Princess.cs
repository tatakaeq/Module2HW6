using Module2HW6.Helper;

namespace Module2HW6.Models.Garment_Сare.Iron
{
    public class Princess : Iron
    {
        public override double PowerConsumption { get; init; } = 2.0;
        public override string Brand { get; init; } = "PRINCESS";
        public override EnergyEfficiencyType EfficiencyType { get; init; } = EnergyEfficiencyType.AAAA;
        public override PriceSegment PriceSegment { get; init; } = PriceSegment.Cheap;
        public override string Model { get; init; } = "328000";
        public override IronType IronType { get; init; } = IronType.Travel;
    }
}