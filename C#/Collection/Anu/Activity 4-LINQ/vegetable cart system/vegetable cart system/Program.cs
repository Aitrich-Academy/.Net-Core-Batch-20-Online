using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vegetable_cart_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vegetable> vegetableList = new List<Vegetable>
            {
                new Vegetable { Name = "Tomato", Price = 1.50m },
                new Vegetable { Name = "Potato", Price = 0.99m },
                new Vegetable { Name = "Carrot", Price = 1.20m },
                new Vegetable { Name = "Broccoli", Price = 1.75m },
                new Vegetable { Name = "Spinach", Price = 2.00m }
            };

            // Step 2: Cart to store selected vegetables
            List<Vegetable> shoppingCart = new List<Vegetable>();

            Console.WriteLine("Welcome to the Vegetable Cart System!\n");

            bool shopping = true;
            while (shopping)
            {
                Console.WriteLine("Available Vegetables:");
                foreach (var veg in vegetableList)
                {
                    Console.WriteLine($"- {veg.Name} : ${veg.Price:F2}");
                }

                Console.Write("\nEnter vegetable name to add to cart (or type 'done' to finish): ");
                string input = Console.ReadLine().Trim();

                if (input.Equals("done", StringComparison.OrdinalIgnoreCase))
                {
                    shopping = false;
                    break;
                }

                // Step 3: Find the vegetable using LINQ
                var selected = vegetableList.FirstOrDefault(v => v.Name.Equals(input, StringComparison.OrdinalIgnoreCase));
                if (selected != null)
                {
                    shoppingCart.Add(selected);
                    Console.WriteLine($"{selected.Name} added to your cart.\n");
                }
                else
                {
                    Console.WriteLine("Vegetable not found. Try again.\n");
                }
            }

            // Step 4: Calculate total bill using LINQ
            var total = shoppingCart.Sum(v => v.Price);

            Console.WriteLine("\nYour Cart:");
            foreach (var item in shoppingCart)
            {
                Console.WriteLine($"- {item.Name} : ${item.Price:F2}");
            }

            Console.WriteLine($"\nTotal Bill: ${total:F2}");
            Console.WriteLine("Thank you for shopping!");
        }
    }
}
        
    

