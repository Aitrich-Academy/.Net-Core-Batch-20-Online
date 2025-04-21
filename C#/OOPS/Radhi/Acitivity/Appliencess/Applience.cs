using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliencess
{
    public abstract class  Applience
    {
        
        
            public abstract void Turnon();
            public void Turnoff()
            {
                Console.WriteLine("Appliance turned off");
            }

        
    }

}
