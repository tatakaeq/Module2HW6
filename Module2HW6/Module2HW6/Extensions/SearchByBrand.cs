using System;
using Module2HW6.Models;

namespace Module2HW6.Extensions
{
    public static class SearchByBrand
    {
        public static Appliances BrandSearch(this Appliances[] appliances, string brand)
        {
            Appliances foundAppliances = null;
            for (var i = 0; i < appliances.Length; i++)
            {
                if (string.Equals(appliances[i].Brand, brand, StringComparison.CurrentCultureIgnoreCase))
                {
                    foundAppliances = appliances[i];
                    break;
                }
                else
                {
                    i++;
                }
            }

            return foundAppliances;
        }
    }
}