using Module2HW6.Models;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public abstract class SearchService : ISearchService
    {
        public abstract Appliances SearchByBrand(Appliances[] appliances, string param);
    }
}