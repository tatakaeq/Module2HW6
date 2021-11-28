using Module2HW6.Helper;

namespace Module2HW6.Models.Garment_Сare.Washer.Automatic
{
    public class Samsung : Automatic
    {
        public override double PowerConsumption { get; init; } = 20.0;
        public override string Brand { get; init; } = "Samsung";
        public override string Model { get; init; } = "WD80K52E0AW/UA";
        public override LoadingType LoadingType { get; init; } = LoadingType.Front;
    }
}