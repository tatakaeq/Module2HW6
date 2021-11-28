using Module2HW6.Helper;

namespace Module2HW6.Models.Computer_Engineering.Mobile_Computers.Tablets
{
    public abstract class Tablet : MobileComputers
    {
        public override MobileComputersType MobileComputersType { get; init; } = MobileComputersType.Smartphone;
        public abstract MobileOsType MobileOsType { get; init; }
        public abstract bool IsHaveStylusForDrawing { get; init; }
        public override bool IsGoodForGaming { get; init; } = false;
    }
}