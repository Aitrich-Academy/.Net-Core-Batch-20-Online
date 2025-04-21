using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliances_Oops
{
    abstract class Appliance
    {
        public abstract void TurnOn();

        public void TurnOff()
        {
            Console.WriteLine("Appliance turned off");
        }
    }

    class WashingMachine : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Washing Maching is Working now!!");
        }

    }

    class Refrigerator : Appliance
    { 
        public override void TurnOn()
        {
            Console.WriteLine(" Refrigerator is cooling now!!");
        }

    }
}
