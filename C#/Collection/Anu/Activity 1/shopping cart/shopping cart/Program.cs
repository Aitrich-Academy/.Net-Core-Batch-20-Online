using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopping_cart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList names = new ArrayList();
            ArrayList prices = new ArrayList();

            while (true)
            {
                Console.Write("Enter item name (or 'done' to finish): ");
                string name = Console.ReadLine();
                if (name.ToLower() == "done")
                    break;

                Console.Write("Enter item price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                names.Add(name);
                prices.Add(price);
            }

            double total = 0;
            Console.WriteLine("\nItems in cart:");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{names[i]} - ${prices[i]}");
                total += (double)prices[i];
            }

            Console.WriteLine($"\nTotal cost: ${total}");
        }
    }
}
