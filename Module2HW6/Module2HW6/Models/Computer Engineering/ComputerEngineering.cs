using Module2HW6.Helper;

namespace Module2HW6.Models.Computer_Engineering
{
    public abstract class ComputerEngineering : Appliances
    {
        public override AppliancesType AppliancesType { get; init; } = AppliancesType.ComputerEngineering;
        public abstract ComputerEngineeringType ComputerEngineeringType { get; init; }
        public abstract bool IsGoodForGaming { get; init; }
    }
}