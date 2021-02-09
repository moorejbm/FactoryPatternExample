using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
        }
        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("the Motorcycle is revving up!");
            Console.WriteLine("Vrooooooom");
        }
    }
}
