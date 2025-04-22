using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace display_car
{
    internal class Car
    {
         public string Model;
         public int Year;

        public void DisplayInfo()
        {
            Console.WriteLine($"This is the {Year} {Model} car. ");
        }
    }
}