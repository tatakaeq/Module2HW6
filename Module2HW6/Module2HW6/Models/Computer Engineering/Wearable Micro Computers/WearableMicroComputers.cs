using Module2HW6.Helper;

namespace Module2HW6.Models.Computer_Engineering.Wearable_Micro_Computers
{
    public abstract class WearableMicroComputers : ComputerEngineering
    {
        public override ComputerEngineeringType ComputerEngineeringType { get; init; } =
            ComputerEngineeringType.WearableMicroComputers;

        public override bool IsGoodForGaming { get; init; } = false;
        public override EnergyEfficiencyType EfficiencyType { get; init; } = EnergyEfficiencyType.AAAA;
        public abstract WearableMicroComputersType WearableMicroComputersType { get; init; }
        public abstract bool IsHaveEsim { get; init; }
        public abstract bool IsAutonomous { get; init; }
        public override bool IsPortable { get; init; } = true;
        public override bool IsCompact { get; init; } = true;
    }
}