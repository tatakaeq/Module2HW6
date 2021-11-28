using Module2HW6.Helper;

namespace Module2HW6.Models.Garment_Сare.Washer.SemiAutomatic
{
    public class Saturn : SemiAutomatic
    {
        public override double PowerConsumption { get; init; } = 15.00;
        public override string Brand { get; init; } = "SATURN";
        public override string Model { get; init; } = "ST-WM/WK1616";
        public override LoadingType LoadingType { get; init; } = LoadingType.Vertical;
    }
}