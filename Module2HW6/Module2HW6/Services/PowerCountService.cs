using Module2HW6.Models;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class PowerCountService : IPowerCountService
    {
        public double GetPowerCountSum(Appliances[] appliances)
        {
            var sumOfPower = 0.0d;
            foreach (var appliance in appliances)
            {
                sumOfPower += appliance.PowerConsumption;
            }

            return sumOfPower;
        }
    }
}