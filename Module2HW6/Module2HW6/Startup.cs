using System;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Services;
using Module2HW6.Services.Abstractions;

namespace Module2HW6
{
    public class Startup
    {
        private readonly IAppliancesProvider _appliancesProvider;
        private readonly IPlugedInService _plugedInService;
        private readonly IInfoService _infoService;
        private readonly IPowerCountService _powerCountService;
        private readonly ISortService _sortService;

        public Startup(
            IPlugedInService plugedInService,
            IInfoService infoService,
            IPowerCountService powerCountService,
            ISortService sortService,
            IAppliancesProvider appliancesProvider)
        {
            _plugedInService = plugedInService;
            _infoService = infoService;
            _sortService = sortService;
            _powerCountService = powerCountService;
            _appliancesProvider = appliancesProvider;
        }

        public void Run()
        {
            var appliance = _appliancesProvider.GetAppliances();
            var searchByBrandService = new SearchByBrandService();
            _plugedInService.PlugIn(appliance);
            var pluggedIn = _plugedInService.GetAppliancesPluggedIn();
            _infoService.WritePluggedInAppliances(pluggedIn);
            _sortService.SortByPowerConsumption(pluggedIn);
            _infoService.WriteSortedByPower(pluggedIn);
            _infoService.WriteSumOfPower(_powerCountService.GetPowerCountSum(pluggedIn));
            var wantToFind = Console.ReadLine();
            var found = searchByBrandService.SearchByBrand(pluggedIn, wantToFind);
            _infoService.WriteFoundAppliance(found);
        }
    }
}