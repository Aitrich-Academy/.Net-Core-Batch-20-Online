using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Inventory_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.DisplayCar();

             
            Car car2 = new Car("Toyota", "Corolla", 2022);
            car2.DisplayCar();

            Console.ReadLine(); 
        }
    }
}
