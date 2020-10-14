using System;
using System.Collections.Generic;
namespace Computer
{
    public class HardDrive
    {
        // Member Variables
        public double TotalStorage;
        public double AvailableStorage;
        public List<Applications> applicationsOnHardDrive;

        public HardDrive(double totalStorage, double availableStorage)
        {
            TotalStorage = totalStorage;
            AvailableStorage = availableStorage;
            applicationsOnHardDrive = new List<Applications>();
        }
        //public void InstallApplication(Applications applications)
        //{
        //    applicationsOnHardDrive.Add(applications);


        //}
    }
}
