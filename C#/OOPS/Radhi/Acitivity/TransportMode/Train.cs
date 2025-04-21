using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportMode
{
    internal class Train:Transport
    {
        public override double TravelTime(double distance)
        {
            double speed = 100.0;
            return distance / speed;

        }
    }
}
