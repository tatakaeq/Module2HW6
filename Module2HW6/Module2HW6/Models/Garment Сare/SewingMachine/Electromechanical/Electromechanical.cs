using Module2HW6.Helper;

namespace Module2HW6.Models.Garment_Сare.SewingMachine.Electromechanical
{
    public abstract class Electromechanical : SewingMachine
    {
        public override SewingMachineType SewingMachineType { get; init; } = SewingMachineType.Electromechanical;
        public override bool IsAutomatic { get; init; } = false;
    }
}