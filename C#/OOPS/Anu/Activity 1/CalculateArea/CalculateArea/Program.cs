using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Length = 15;
            rect.Width = 10;

            double area = rect.CalculateArea();
            Console.WriteLine("Rectangle area is :" + area);

        }
    }
}
