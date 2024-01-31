using System;
using factory_pattern;

namespace FactoryPatternVehicles
{


    class program
    {
        static void Main(String[] args)
        {
            int numOfWheels;
            bool input = false;
            do
            {
                Console.WriteLine("Enter the amopunt of tires for the vehicle you want to create;");

                input = int.TryParse(Console.ReadLine(), out numOfWheels);

            } while (input == false);
            
            IVehicle vehicle = VehicleFactory.GetVehicle(numOfWheels);
            vehicle.Drive();
        }
    }
}