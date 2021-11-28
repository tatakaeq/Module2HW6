using Module2HW6.Helper;

namespace Module2HW6.Models.Garment_Сare
{
    public abstract class GarmentСare : Appliances
    {
        public override AppliancesType AppliancesType { get; init; } = AppliancesType.GarmentСare;
        public abstract GarmentСareType GarmentСareType { get; init; }
    }
}