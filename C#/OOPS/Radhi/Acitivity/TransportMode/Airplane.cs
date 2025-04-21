using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportMode
{
    public class Airplane:Transport
    {
        public override double TravelTime(double distance)
        {
            double speed = 800.0;
            return distance / speed;

        }
    }
}
