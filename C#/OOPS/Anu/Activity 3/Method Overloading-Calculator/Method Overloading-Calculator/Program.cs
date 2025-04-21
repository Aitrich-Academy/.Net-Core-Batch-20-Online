using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculator calc = new Calculator();

            int sum1 = calc.Add(5, 10);                  
            double sum2 = calc.Add(3.5, 2.8);              
            int sum3 = calc.Add(1, 2, 3);                

            Console.WriteLine("Sum of two integers: " + sum1);
            Console.WriteLine("Sum of two doubles: " + sum2);
            Console.WriteLine("Sum of three integers: " + sum3);

            Console.ReadLine();  
        }
    }
}
