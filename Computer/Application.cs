using System;
namespace Computer
{
    public class Application
    {
        public string ApplicationName;
        public string ApplicationType;
        public double RequiredRAM;
        public double RequiredStorage;

        public Application()
        {
            ApplicationName = "Slack";
            ApplicationType = "Messaging Service";
            RequiredRAM = 4.0; // GB
            RequiredStorage = 0.512 // GB
        }
    }
}
