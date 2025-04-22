using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliances_oops
{
    abstract class Appliances
    {
        public abstract void TurnOn();
        public void TurnOff()
        {
            Console.WriteLine("Appliance turned off.");
        }

    }

    class WashingMachine : Appliances
    {
        public override void TurnOn()
        {
            Console.WriteLine("Washing machine is now running.");
        }
    }

    
    class Refrigerator : Appliances
    {
        public override void TurnOn()
        {
            Console.WriteLine("Refrigerator is  very cooling.");
        }
    }
}
