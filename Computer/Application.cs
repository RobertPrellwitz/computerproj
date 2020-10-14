using System;
using System.Collections.Generic;
namespace Computer
{
    public abstract class Applications
    {
        public string ApplicationName;
        public string ApplicationType;
        public double RequiredRAM;
        public double RequiredStorage;

        public Applications()
        {
            ApplicationName = "Slack";
            ApplicationType = "Messaging Service";
            RequiredRAM = 4.0; // GB
            RequiredStorage = 0.512; // GB
        }
    }
}
