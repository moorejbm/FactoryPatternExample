using System;

namespace FactoryPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfWheels;
            bool input = false;
            do
            {
                Console.WriteLine("Enter the amonut of the tites for the vechicle you want to create:");

                input = int.TryParse(Console.ReadLine(), out numOfWheels);

            } while (input == false);

            var vehicle = VehicleFactory.GetVechicle(numOfWheels);
            vehicle.Drive();
            
        }
    }
}
