using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Array of product prices
        decimal[] prices = { 99.99m, 199.99m, 49.99m, 150.00m, 75.00m };

        // LINQ query to filter prices greater than 100
        var selectedPrices = prices.Where(p => p > 100);

        // Calculate the average price of the selected products
        decimal averagePrice = selectedPrices.Average();

        // Get the total count of products selected
        int count = selectedPrices.Count();

        // Display the total count and average price
        Console.WriteLine($"Total count of products with prices greater than 100: {count}");
        Console.WriteLine($"Average price of selected products: {averagePrice:C}");
    }
}