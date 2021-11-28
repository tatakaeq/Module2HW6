using Module2HW6.Helper;

namespace Module2HW6.Models.Computer_Engineering.Personal_Computers.Nettop
{
    public class ArtlineBusiness : Nettop
    {
        public override double PowerConsumption { get; init; } = 0.67;
        public override string Brand { get; init; } = "Artline";
        public override PriceSegment PriceSegment { get; init; } = PriceSegment.Medium;
        public override string Model { get; init; } = "B12v27";
        public override bool IsGoodForGaming { get; init; } = false;
        public override OsType OsType { get; init; } = OsType.Windows;
    }
}