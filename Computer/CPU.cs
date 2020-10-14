using System;
using System.Collections.Generic;
namespace Computer
{
    public class CPU
    {
        // Member Variables
        public string Manufacturer;
        public string Name;
        public CPU(string manufacturer, string name)
       
        {
            Manufacturer = manufacturer;
            Name = name;

        }

        public bool CheckRequirements(Applications:Games app, HardDrive hd, RAM ram, GPU gpu) 
        {
            if (hd.AvailableStorage > app.RequiredStorage && ram.TotalGigabytes > app.RequiredRAM && gpu.EffectiveMemory > app.RequiredEffectiveMemory)

            {
                ProcessInstall(app, hd, ram);
                return true;
            }
            return false;


        }

        public void ProcessInstall(Applications app, HardDrive hd, RAM ram)
        {
            hd.applicationsOnHardDrive.Add(app);



        }
    }
}
