using Module2HW6.Helper;

namespace Module2HW6.Models.Computer_Engineering.Personal_Computers
{
    public abstract class PersonalComputers : ComputerEngineering
    {
        public override Size Size { get; init; } = Size.Medium;
        public override bool IsPortable { get; init; } = false;

        public override ComputerEngineeringType ComputerEngineeringType { get; init; } =
            ComputerEngineeringType.PersonalComputers;

        public abstract PersonalComputersType PersonalComputersType { get; init; }
        public abstract OsType OsType { get; init; }
    }
}