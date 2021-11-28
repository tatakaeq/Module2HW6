using System;
using Module2HW6.Models;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class InfoService : IInfoService
    {
        public void WritePluggedInAppliances(Appliances[] appliances)
        {
            Console.WriteLine($"Plugged in:");
            foreach (var appliance in appliances)
            {
                Console.WriteLine($"{appliance.GetType().Name}, Power Consumption: {appliance.PowerConsumption}");
            }
        }

        public void WriteSumOfPower(double sum)
        {
            Console.WriteLine($"{Environment.NewLine}Power Consumption sum is {sum}");
        }

        public void WriteSortedByPower(Appliances[] appliances)
        {
            Console.WriteLine($"{Environment.NewLine}Sorted by Power Consumption:");
            foreach (var appliance in appliances)
            {
                Console.WriteLine($"{appliance.GetType().Name}, Power Consumption: {appliance.PowerConsumption}");
            }
        }

        public void WriteFoundAppliance(Appliances appliance)
        {
            if (appliance != null)
            {
                Console.WriteLine($"Found appliance is {appliance.GetType().Name}, Power Consumption: {appliance.PowerConsumption}");
            }
            else
            {
                Console.WriteLine($"No such Appliance");
            }
        }
    }
}