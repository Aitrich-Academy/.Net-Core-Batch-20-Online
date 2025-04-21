using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Modes
{
    abstract class Transport
    {
        public abstract double TravelTime(double distance);
    }

    class Car : Transport
    {
        private double speed = 60; // km/h

        public override double TravelTime(double distance)
        {
            return distance / speed;
        }
    }
    class Train : Transport
    {
        private double speed = 100; // km/h

        public override double TravelTime(double distance)
        {
            return distance / speed;
        }
    }
    class Airplane : Transport
    {
        private double speed = 800; // km/h

        public override double TravelTime(double distance)
        {
            return distance / speed;
        }
    }
}
