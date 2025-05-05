using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9 };

            // LINQ query to filter numbers whose square is more than 20
            var result = numbers
                         .Where(n => n * n > 20)
                         .Select(n => new { Number = n, Square = n * n });

            Console.WriteLine("Numbers and their squares greater than 20:\n");

            // Display the results
            foreach (var item in result)
            {
                Console.WriteLine($"Number: {item.Number}, Square: {item.Square}");
            }

            Console.ReadLine();
        }
    }
    
}
