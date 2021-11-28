using System.Collections.Generic;
using Module2HW6.Models;

namespace Module2HW6.Helper
{
    public class PowerConsumptionComparer : IComparer<Appliances>
    {
        public int Compare(Appliances x, Appliances y)
        {
            if (x?.PowerConsumption > y?.PowerConsumption)
            {
                return 1;
            }
            else if (x?.PowerConsumption < y?.PowerConsumption)
            {
                return -1;
            }

            return 0;
        }
    }
}