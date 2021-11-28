using Module2HW6.Helper;

namespace Module2HW6.Models.Garment_Сare.SewingMachine
{
    public abstract class SewingMachine : Appliances
    {
        public override Size Size { get; init; } = Size.Medium;
        public override AppliancesType AppliancesType { get; init; } = AppliancesType.GarmentСare;
        public override bool IsPortable { get; init; } = false;
        public override bool IsCompact { get; init; } = true;
        public abstract SewingMachineType SewingMachineType { get; init; }
        public abstract bool IsAutomatic { get; init; }
        public abstract bool IsWithDisplay { get; init; }
    }
}