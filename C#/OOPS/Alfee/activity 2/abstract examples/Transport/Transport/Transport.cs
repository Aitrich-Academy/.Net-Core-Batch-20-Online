using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_oops
{
    abstract class Transport
    {
        public abstract void TravelTime(double distance);
    }

    class Car : Transport
    {
        private double speed = 60;

        public override void TravelTime(double distance)
        {
            double time = distance / speed;
            Console.WriteLine($"Car: Distance = {distance} km, Travel Time = {time:F2} hours");
        }
    }

    class Train : Transport
    {
        private double speed = 100;

        public override void TravelTime(double distance)
        {
            double time = distance / speed;
            Console.WriteLine($"Train: Distance = {distance} km, Travel Time = {time:F2} hours");
        }
    }

    class Airplane : Transport
    {
        private double speed = 700;

        public override void TravelTime(double distance)
        {
            double time = distance / speed;
            Console.WriteLine($"Airplane: Distance = {distance} km, Travel Time = {time:F2} hours");
        }
    }
}
