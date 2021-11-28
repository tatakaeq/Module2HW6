using Module2HW6.Helper;

namespace Module2HW6.Models.Kitchen_Appliances.Fridge
{
    public class BoschKg : Fridge
    {
        public override double PowerConsumption { get; init; } = 55.0;
        public override string Brand { get; init; } = "Bosch";
        public override string Model { get; init; } = "N39XW326";
        public override CoolingSystemType CoolingSystemType { get; init; } = CoolingSystemType.Compressor;
        public override FreezerLocation FreezerLocation { get; init; } = FreezerLocation.Downside;
        public override InstallationType InstallationType { get; init; } = InstallationType.Freestanding;
        public override bool HasDisplay { get; init; } = false;
        public override bool HasMoreThanOneCompartment { get; init; } = true;
    }
}