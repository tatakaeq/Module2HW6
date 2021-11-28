using Module2HW6.Helper;

namespace Module2HW6.Models.Computer_Engineering.Mobile_Computers.Laptops
{
    public class AsusRogStrix : Laptop
    {
        public override Size Size { get; init; } = Size.Medium;
        public override double PowerConsumption { get; init; } = 1.0;
        public override string Brand { get; init; } = "Asus";
        public override EnergyEfficiencyType EfficiencyType { get; init; } = EnergyEfficiencyType.AA;
        public override PriceSegment PriceSegment { get; init; } = PriceSegment.Expensive;
        public override string Model { get; init; } = "G513IE-HF032";
        public override bool IsGoodForGaming { get; init; } = true;
        public override OsType OsType { get; init; } = OsType.Windows;
        public override bool IsHaveANumPad { get; init; } = true;
    }
}