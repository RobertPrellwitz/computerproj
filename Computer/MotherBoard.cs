using System;
using System.Collections.Generic;
namespace Computer
{
    public class MotherBoard
    {
        // Member Variables
        public string Manufacturer;
        public CPU Processor;
        public RAM TemporaryMemory;
        public HardDrive Storage;
        public  GPU Graphics;

        public MotherBoard(string manufacturer, CPU cpu, RAM ram, HardDrive hardDrive, GPU gpu)
        {
            Manufacturer = manufacturer;
            TemporaryMemory = ram;
            Processor = cpu;
            Storage = hardDrive;
            Graphics = gpu;

        }
        public void PickMotherBoard()

        {
            Console.WriteLine("Please select your Motherboard");

        }
        //public void InstallApplication(Applications applications)
        //{
        //    if (temporaryMemory > applications.RequiredRAM)
        //    {
        //        storage.applicationsOnHardDrive.Add(applications);
        //    }                
        //}


    }
}
