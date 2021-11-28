using Module2HW6.Models;

namespace Module2HW6.Services.Abstractions
{
    public interface IPlugedInService
    {
        void PlugIn(Appliances[] appliances);
        Appliances[] GetAppliancesPluggedIn();
    }
}