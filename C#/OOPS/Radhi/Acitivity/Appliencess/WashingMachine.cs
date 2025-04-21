using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliencess
{
   public class WashingMachine:Applience
    {
        public override void Turnon()
        {
            Console.WriteLine("Washing machine is now running.");
        }


    }
}
