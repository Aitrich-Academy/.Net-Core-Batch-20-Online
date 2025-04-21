using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Modes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double distance = 300; 

            Transport car = new Car();
            Transport train = new Train();
            Transport airplane = new Airplane();

            Console.WriteLine($"Distance: {distance} km\n");

            Console.WriteLine($"Car travel time: {car.TravelTime(distance):F2} hours");
            Console.WriteLine($"Train travel time: {train.TravelTime(distance):F2} hours");
            Console.WriteLine($"Airplane travel time: {airplane.TravelTime(distance):F2} hours");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
    }

