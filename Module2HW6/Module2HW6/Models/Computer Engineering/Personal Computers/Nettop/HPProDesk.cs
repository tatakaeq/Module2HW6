using Module2HW6.Helper;

namespace Module2HW6.Models.Computer_Engineering.Personal_Computers.Nettop
{
    public class HPProDesk : Nettop
    {
        public override double PowerConsumption { get; init; } = 0.3;
        public override string Brand { get; init; } = "HP";
        public override PriceSegment PriceSegment { get; init; } = PriceSegment.Expensive;
        public override string Model { get; init; } = "400G6DM";
        public override bool IsGoodForGaming { get; init; } = false;
        public override OsType OsType { get; init; } = OsType.Windows;
    }
}