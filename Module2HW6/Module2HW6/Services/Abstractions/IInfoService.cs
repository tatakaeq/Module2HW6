using Module2HW6.Models;

namespace Module2HW6.Services.Abstractions
{
    public interface IInfoService
    {
        void WritePluggedInAppliances(Appliances[] appliances);
        void WriteSumOfPower(double sum);
        void WriteSortedByPower(Appliances[] appliances);
        void WriteFoundAppliance(Appliances appliance);
    }
}