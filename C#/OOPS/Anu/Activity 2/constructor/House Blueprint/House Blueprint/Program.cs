using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Blueprint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House("Red", 3, true);
            House house2 = new House("Blue", 5, false);
            House house3 = new House("Green", 4, true);

            
            house1.ShowInfo();
            house2.ShowInfo();
            house3.ShowInfo();

            Console.ReadLine();  
        }
    }
}
