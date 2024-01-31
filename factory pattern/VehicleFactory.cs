using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numOfWheels) 
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
