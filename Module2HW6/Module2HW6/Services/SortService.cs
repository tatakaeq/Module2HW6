using System;
using Module2HW6.Helper;
using Module2HW6.Models;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class SortService : ISortService
    {
        public void SortByPowerConsumption(Appliances[] appliances)
        {
            Array.Sort(appliances, new PowerConsumptionComparer());
        }
    }
}