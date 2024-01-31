using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_pattern
{
    public class ConsoleLogger
    {
        public static void VehicleStartUpDialogue() 
        {
            Console.WriteLine("Put key in ignition!");
            Thread.Sleep(1000);
            Console.WriteLine("Turn key!");
            Thread.Sleep(1000);
            
        }
    }
}
