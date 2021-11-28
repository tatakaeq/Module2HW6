using Module2HW6.Models;
using Module2HW6.Models.Computer_Engineering.Mobile_Computers.Smartphones;
using Module2HW6.Models.Computer_Engineering.Mobile_Computers.Tablets;
using Module2HW6.Models.Computer_Engineering.Personal_Computers.Desktop;
using Module2HW6.Models.Computer_Engineering.Personal_Computers.Monoblock;
using Module2HW6.Models.Computer_Engineering.Personal_Computers.Nettop;
using Module2HW6.Models.Computer_Engineering.Wearable_Micro_Computers.SmartRing;
using Module2HW6.Models.Computer_Engineering.Wearable_Micro_Computers.SmartWatch;
using Module2HW6.Models.Garment_Сare.Iron;
using Module2HW6.Models.Garment_Сare.SewingMachine.Computer;
using Module2HW6.Models.Garment_Сare.Washer.Automatic;
using Module2HW6.Models.Garment_Сare.Washer.SemiAutomatic;
using Module2HW6.Models.Kitchen_Appliances.Fridge;
using Module2HW6.Models.Kitchen_Appliances.Mixer;
using Module2HW6.Models.Kitchen_Appliances.Stove;
using Module2HW6.Providers.Abstractions;

namespace Module2HW6.Providers
{
    public class AppliancesProvider : IAppliancesProvider
    {
        public Appliances[] GetAppliances()
        {
            return new Appliances[]
            {
                new AppleiMac(),
                new ArtlineBusiness(),
                new ArtlineGamingX(),
                new Iphone(),
                new Jakcom(),
                new Samsung(),
                new BoschMfq(),
                new LenovoTab(),
                new SamsungRt(),
                new GorenjeEi(),
                new BoschKg(),
                new Princess(),
                new Minerva(),
                new ElectroluxRk(),
                new AppleWatch(),
                new Saturn()
            };
        }
    }
}