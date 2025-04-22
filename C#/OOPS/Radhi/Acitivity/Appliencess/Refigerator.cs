using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliencess
{
    public class Refigerator:Applience
    {
        public override void Turnon()
        {
            Console.WriteLine("Refrigerator is now cooling.");
        }
    }
}
