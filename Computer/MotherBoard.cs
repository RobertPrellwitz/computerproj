using System;
namespace Computer
{
    public class MotherBoard
    {
        // Member Variables
        public string manufacturer;
        public CPU processor;
        public RAM temporaryMemory;
        public HardDrive storage;
        public  GPU graphics;

        public MotherBoard(string manufacturer, CPU cpu, RAM ram, HardDrive hardDrive, GPU gpu)
        {
        }
    }
}
