﻿using Module2HW6.Models;

namespace Module2HW6.Providers.Abstractions
{
    public interface IAppliancesProvider
    {
        Appliances[] GetAppliances();
    }
}