using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 6, 23, 0, 9, 6, 5 };
            var x = from e in numbers
                    where (e < 10 && e > 5)
                    select e;

            var methodesytaxQuery = numbers.Where(e => e > 10 && e < 5).Select(e => e);
            foreach(var e in x)
                {
                Console.WriteLine(e);
            }
             

            
        }
    }
}
