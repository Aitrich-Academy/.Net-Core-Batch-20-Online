using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportMode
{
    internal class Car:Transport
    {
        public override double TravelTime(double distance)
        {
            double speed = 60.0;
            return distance / speed;

        }
    }
}
