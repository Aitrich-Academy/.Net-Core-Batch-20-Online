using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace Appliances_Oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WashingMachine mywashing=new WashingMachine();
            Refrigerator myref= new Refrigerator();

            mywashing.TurnOn();
            mywashing.TurnOff();

            Console.WriteLine();

            myref.TurnOn();
            myref.TurnOff();

          
            
        }
    }
}
