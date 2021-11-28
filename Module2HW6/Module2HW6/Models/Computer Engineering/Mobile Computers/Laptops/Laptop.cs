using Module2HW6.Helper;

namespace Module2HW6.Models.Computer_Engineering.Mobile_Computers.Laptops
{
    public abstract class Laptop : MobileComputers
    {
        public override MobileComputersType MobileComputersType { get; init; } = MobileComputersType.Laptop;
        public abstract OsType OsType { get; init; }
        public abstract bool IsHaveANumPad { get; init; }
    }
}