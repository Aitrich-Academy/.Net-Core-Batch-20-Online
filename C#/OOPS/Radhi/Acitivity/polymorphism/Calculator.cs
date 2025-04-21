using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class Calculator
    {
        int a;
        int b;
        int add(int a, int b)
        {
            return a + b;

        }
        double add(double a, double b)
        {
            return (a + b);


        }
        int add(int a, int b, int c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine($"2+3 =" + calc.add(2, 3));          
            Console.WriteLine("2.5+3.7 = " + calc.add(2.5, 3.7));   
            Console.WriteLine("1+2+3 = " + calc.add(1, 2, 3));
        }
    }
}
