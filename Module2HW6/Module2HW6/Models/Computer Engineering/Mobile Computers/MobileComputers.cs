using Module2HW6.Helper;

namespace Module2HW6.Models.Computer_Engineering.Mobile_Computers
{
    public abstract class MobileComputers : ComputerEngineering
    {
        public override bool IsPortable { get; init; } = true;

        public override ComputerEngineeringType ComputerEngineeringType { get; init; } =
            ComputerEngineeringType.MobileComputers;

        public abstract MobileComputersType MobileComputersType { get; init; }
        public override bool IsCompact { get; init; } = true;
    }
}