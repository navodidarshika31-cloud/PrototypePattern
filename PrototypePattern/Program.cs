using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceRobot serviceRobot = new ServiceRobot();

            serviceRobot.ModelName = "SR-100";
            serviceRobot.BatteryCapacity = 10;
            serviceRobot.SoftwareVersion = "v1.0";
            serviceRobot.ServiceTask = "Customer Assistance";

            ServiceRobot clonedServiceRobot =
                (ServiceRobot)serviceRobot.Clone();

            clonedServiceRobot.BatteryCapacity = 15;
            clonedServiceRobot.SoftwareVersion = "v2.0";

            Console.WriteLine("===== ORIGINAL SERVICE ROBOT =====");

            serviceRobot.Display();

            Console.WriteLine("Service Task: "
                + serviceRobot.ServiceTask);

            Console.WriteLine("\n===== CLONED SERVICE ROBOT =====");

            clonedServiceRobot.Display();

            Console.WriteLine("Service Task: "
                + clonedServiceRobot.ServiceTask);

            IndustrialRobot industrialRobot = new IndustrialRobot();

            industrialRobot.ModelName = "IR-200";
            industrialRobot.BatteryCapacity = 20;
            industrialRobot.SoftwareVersion = "v1.5";
            industrialRobot.IndustrialTask = "Welding";

            IndustrialRobot clonedIndustrialRobot =
                (IndustrialRobot)industrialRobot.Clone();

            clonedIndustrialRobot.BatteryCapacity = 25;
            clonedIndustrialRobot.SoftwareVersion = "v2.0";

            Console.WriteLine("\n===== CLONED INDUSTRIAL ROBOT =====");

            clonedIndustrialRobot.Display();

            Console.WriteLine("Industrial Task: "
                + clonedIndustrialRobot.IndustrialTask);

            EntertainmentRobot entertainmentRobot =
                new EntertainmentRobot();

            entertainmentRobot.ModelName = "ER-300";
            entertainmentRobot.BatteryCapacity = 12;
            entertainmentRobot.SoftwareVersion = "v1.2";
            entertainmentRobot.EntertainmentFeature =
                "Interactive Dancing";

            EntertainmentRobot clonedEntertainmentRobot =
                (EntertainmentRobot)entertainmentRobot.Clone();

            clonedEntertainmentRobot.BatteryCapacity = 18;
            clonedEntertainmentRobot.SoftwareVersion = "v2.1";

            Console.WriteLine("\n===== CLONED ENTERTAINMENT ROBOT =====");

            clonedEntertainmentRobot.Display();

            Console.WriteLine("Entertainment Feature: "
                + clonedEntertainmentRobot.EntertainmentFeature);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}