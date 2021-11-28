using Module2HW6.Helper;

namespace Module2HW6.Models.Computer_Engineering.Personal_Computers.Monoblock
{
    public class ArtlineGaming : Monoblock
    {
        public override double PowerConsumption { get; init; } = 1.0;
        public override string Brand { get; init; } = "Artline";
        public override PriceSegment PriceSegment { get; init; } = PriceSegment.Medium;
        public override string Model { get; init; } = "G77v16";
        public override bool IsGoodForGaming { get; init; } = true;
        public override OsType OsType { get; init; } = OsType.Windows;
    }
}