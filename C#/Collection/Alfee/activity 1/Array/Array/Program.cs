using System;
using System.Collections;

class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Item(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

class Program
{
    static void Main()
    {
        // Create an ArrayList to store items in the cart
        ArrayList cart = new ArrayList();

        bool exit = false;

        while (!exit)
        {
            // Display Menu
            Console.WriteLine("\nShopping Cart System");
            Console.WriteLine("1. Add Item to Cart");
            Console.WriteLine("2. View Cart & Total Cost");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Add Item to Cart
                    Console.Write("Enter item name: ");
                    string itemName = Console.ReadLine();
                    Console.Write("Enter item price: ");
                    decimal itemPrice;

                    // Validate price input
                    if (decimal.TryParse(Console.ReadLine(), out itemPrice) && itemPrice > 0)
                    {
                        cart.Add(new Item(itemName, itemPrice));
                        Console.WriteLine($"Item '{itemName}' added to the cart.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid price. Please enter a valid positive price.");
                    }
                    break;

                case "2":
                    // View Cart & Total Cost
                    decimal totalCost = 0;
                    Console.WriteLine("\nItems in the Cart:");
                    foreach (Item item in cart)
                    {
                        Console.WriteLine($"{item.Name} - ${item.Price}");
                        totalCost += item.Price;
                    }

                    Console.WriteLine($"\nTotal Cost: ${totalCost}");
                    break;

                case "3":
                    // Exit
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }

        Console.WriteLine("Thank you for shopping with us!");
    }
}