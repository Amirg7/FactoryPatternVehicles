using System;
using System.Threading;

namespace FactoryPatternVehicles
{
    public class ConsoleLogger
    {
        public static void VehicleStartUpDialogue()
        {
            Console.WriteLine("Put Key in ignition!");
            Thread.Sleep(1000);
            Console.WriteLine("Turn Key!");
            Thread.Sleep(1000);



        }
    }
}
