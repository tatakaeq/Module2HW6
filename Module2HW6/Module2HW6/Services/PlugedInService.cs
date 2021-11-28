using Module2HW6.Models;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class PlugedInService : IPlugedInService
    {
        private Appliances[] Appliances { get; set; }
        public void PlugIn(Appliances[] appliances)
        {
            Appliances = appliances;
        }

        public Appliances[] GetAppliancesPluggedIn()
        {
            return Appliances;
        }
    }
}