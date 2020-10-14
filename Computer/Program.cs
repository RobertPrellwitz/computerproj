using System;
using System.Collections.Generic;

namespace Computer
{
    class Program
    {
        static void Main(string[] args)
        {
            GPU gpu = new GPU("Invidia", 8);
            CPU cpu = new CPU("intel", "386");
            HardDrive seagate = new HardDrive(12, 12);
            RAM memory = new RAM(12, "micron");

            MotherBoard killer = new MotherBoard("asus", cpu, memory, seagate, gpu);

            Computer computer = new Computer(killer);



            // Method to select motherboard
                // call a list motherboards
            //Method to select GPU
                // call alist GPU
            // Methond to select CPU
            


        }







    }
}
