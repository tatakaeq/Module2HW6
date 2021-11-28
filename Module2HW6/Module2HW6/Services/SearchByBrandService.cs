using Module2HW6.Extensions;
using Module2HW6.Models;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class SearchByBrandService : SearchService, ISearchService
    {
        public override Appliances SearchByBrand(Appliances[] appliances, string param)
        {
            Appliances foundAppliance = appliances.BrandSearch(param);
            return foundAppliance;
        }
    }
}