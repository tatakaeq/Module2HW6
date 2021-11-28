using Module2HW6.Helper;

namespace Module2HW6.Models.Computer_Engineering.Wearable_Micro_Computers.SmartWatch
{
    public abstract class SmartWatch : WearableMicroComputers
    {
        public override WearableMicroComputersType WearableMicroComputersType { get; init; } =
            WearableMicroComputersType.SmartWatch;

        public override bool IsAutonomous { get; init; } = true;
        public abstract bool IsHaveGps { get; init; }
    }
}