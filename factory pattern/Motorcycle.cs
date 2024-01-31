using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern
{
    public class Motorcycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("The Motorcycle is revving up");
            Console.WriteLine("vroooooom");
        }
    }
}
