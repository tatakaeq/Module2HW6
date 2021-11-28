using Module2HW6.Helper;

namespace Module2HW6.Models.Garment_Сare.SewingMachine.Computer
{
    public abstract class Computer : SewingMachine
    {
        public override SewingMachineType SewingMachineType { get; init; } = SewingMachineType.Computer;
        public override bool IsAutomatic { get; init; } = true;
        public override bool IsWithDisplay { get; init; } = true;
    }
}