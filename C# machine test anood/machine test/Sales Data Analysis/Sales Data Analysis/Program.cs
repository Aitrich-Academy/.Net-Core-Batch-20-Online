using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Data_Analysis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] sales = new double[7];
            Console.WriteLine("Enter sales data for 7 days:");
            for (int i = 0; i < 7; i++)
            {

                Console.Write($"Day {i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out sales[i]) || sales[i] < 0) 
                {
                    Console.WriteLine("Invalid input. Please enter a positive number:");
                }
            }

            double total = 0;
            foreach (double sale in sales)
            {
                total += sale;
            }
            double average = total / 7;

            double highest = sales[0];
            double lowest = sales[0];
            int highestIndex = 0;
            int lowestIndex = 0;

            for (int i = 1; i < 7; i++)
            {
                if (sales[i] > highest)
                {
                    highest = sales[i];
                    highestIndex = i;
                }

                if (sales[i] < lowest)
                {
                    lowest = sales[i];
                    lowestIndex = i;
                }
            }

             
            Console.WriteLine($"\nTotal Sales: {total:C}");
            Console.WriteLine($"Average Sales: {average:C}");
            Console.WriteLine($"Highest Sales: {highest:C} on Day {highestIndex + 1}");
            Console.WriteLine($"Lowest Sales: {lowest:C} on Day {lowestIndex + 1}");

            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
