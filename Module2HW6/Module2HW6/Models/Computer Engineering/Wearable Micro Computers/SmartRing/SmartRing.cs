using Module2HW6.Helper;

namespace Module2HW6.Models.Computer_Engineering.Wearable_Micro_Computers.SmartRing
{
    public abstract class SmartRing : WearableMicroComputers
    {
        public override WearableMicroComputersType WearableMicroComputersType { get; init; } =
            WearableMicroComputersType.SmartRing;

        public abstract bool IsNeedsSmartPhone { get; init; }
        public abstract bool HasNfc { get; init; }
    }
}