using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCartApp.Models;
using ShoppingCartApp.Interfaces;
using ShoppingCartApp.Exceptions;

namespace ShoppingCartApp
{
    class Program
    {
        static void Main()
        {
            IShoppingCart cart = new ShoppingCart();
            bool exit = false;

            Console.WriteLine("Welcome to the Shopping Cart Application!");

            while (!exit)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Remove Item");
                Console.WriteLine("3. Apply Discount");
                Console.WriteLine("4. View Cart");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                var choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter item name: ");
                            var name = Console.ReadLine();
                            Console.Write("Enter price: ");
                            var price = decimal.Parse(Console.ReadLine());
                            Console.Write("Enter quantity: ");
                            var quantity = int.Parse(Console.ReadLine());
                            var item = new Item(name, price, quantity);
                            cart.AddItem(item);
                            Console.WriteLine("Item added successfully.");
                            break;

                        case "2":
                            Console.Write("Enter item name to remove: ");
                            var removeName = Console.ReadLine();
                            cart.RemoveItem(removeName);
                            Console.WriteLine("Item removed successfully.");
                            break;

                        case "3":
                            Console.Write("Enter discount percentage: ");
                            var discount = decimal.Parse(Console.ReadLine());
                            cart.ApplyDiscount(discount);
                            Console.WriteLine("Discount applied successfully.");
                            break;

                        case "4":
                            cart.DisplayCart();
                            break;

                        case "5":
                            exit = true;
                            Console.WriteLine("Thank you for using the Shopping Cart Application!");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format. Please enter the correct data type.");
                }
                 
            }
        }
    }
}