using Module2HW6.Models;

namespace Module2HW6.Services.Abstractions
{
    public interface ISearchService
    {
        Appliances SearchByBrand(Appliances[] appliances, string param);
    }
}