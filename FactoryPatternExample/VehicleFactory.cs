using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExample
{
    public static class VehicleFactory
    {
        public static IVehicle GetVechicle(int numOfWheels)
        {
            switch (numOfWheels)
            {
                case 2:
                    return new Motorcycle();
                case 3:
                    return new ThreeWheeler();
                case 4:
                    return new Car();
                default:
                    return new Car();


            }
        }

    }
}


