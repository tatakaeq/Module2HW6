using Module2HW6.Helper;

namespace Module2HW6.Models.Kitchen_Appliances
{
    public abstract class KitchenAppliances : Appliances
    {
        public override AppliancesType AppliancesType { get; init; } = AppliancesType.KitchenAppliances;
        public abstract KitchenAppliancesType KitchenAppliancesType { get; init; }
    }
}