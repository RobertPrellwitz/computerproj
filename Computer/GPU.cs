using System;
using System.Collections.Generic;
namespace Computer
{
    public class GPU
    {
        //Member Variables
        public string Manufacturer;
        public double EffectiveMemory;

        public GPU(string manufacturer, double effectiveMemory)
        {
            Manufacturer = manufacturer;
            EffectiveMemory = effectiveMemory;

        }

    }
}
