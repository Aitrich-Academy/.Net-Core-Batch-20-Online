using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] prices = { 99.99m, 199.99m, 49.99m, 150.00m, 75.00m };

            // LINQ query to filter prices > 100
            var filteredPrices = prices.Where(price => price > 100);

            // Count and average calculation
            int count = filteredPrices.Count();
            decimal average = filteredPrices.Any() ? filteredPrices.Average() : 0m;

            // Output
            Console.WriteLine("Products with price > 100:");
            foreach (var price in filteredPrices)
            {
                Console.WriteLine($"- ${price}");
            }

            Console.WriteLine($"\nTotal Count: {count}");
            Console.WriteLine($"Average Price: ${average:F2}");

            // Keep console open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
    

