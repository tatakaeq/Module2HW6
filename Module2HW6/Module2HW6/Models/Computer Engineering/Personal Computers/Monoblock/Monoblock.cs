using Module2HW6.Helper;

namespace Module2HW6.Models.Computer_Engineering.Personal_Computers.Monoblock
{
    public abstract class Monoblock : PersonalComputers
    {
        public override EnergyEfficiencyType EfficiencyType { get; init; } = EnergyEfficiencyType.AAA;
        public override PersonalComputersType PersonalComputersType { get; init; } = PersonalComputersType.Monoblock;
        public override bool IsCompact { get; init; } = true;
    }
}