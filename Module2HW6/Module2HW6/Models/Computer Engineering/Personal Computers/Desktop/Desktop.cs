using Module2HW6.Helper;

namespace Module2HW6.Models.Computer_Engineering.Personal_Computers.Desktop
{
    public abstract class Desktop : PersonalComputers
    {
        public override PersonalComputersType PersonalComputersType { get; init; } = PersonalComputersType.Desktop;
        public override bool IsCompact { get; init; } = false;
    }
}