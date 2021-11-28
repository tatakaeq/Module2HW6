using Module2HW6.Helper;

namespace Module2HW6.Models.Kitchen_Appliances.Fridge
{
    public class SamsungRt : Fridge
    {
        public override double PowerConsumption { get; init; } = 30.0;
        public override string Brand { get; init; } = "Samsung";
        public override string Model { get; init; } = "32K5000S9/UA";
        public override CoolingSystemType CoolingSystemType { get; init; } = CoolingSystemType.Compressor;
        public override FreezerLocation FreezerLocation { get; init; } = FreezerLocation.Upside;
        public override InstallationType InstallationType { get; init; } = InstallationType.Freestanding;
        public override bool HasDisplay { get; init; } = false;
        public override bool HasMoreThanOneCompartment { get; init; } = true;
    }
}