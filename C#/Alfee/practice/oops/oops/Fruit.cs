using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class Fruit
    {
        public string Name;
        public string color;

        public void display()
        {
            Console.WriteLine($"Fruit:{Name}:{color}");
        }

    }
}
