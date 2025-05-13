using System;
using System.Collections.Generic;
using System.Linq;

class Vegetable
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Vegetable(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

class Program
{
    static void Main()
    {
        // List of vegetables with prices
        List<Vegetable> vegetables = new List<Vegetable>
        {
            new Vegetable("Carrot", 1.50m),
            new Vegetable("Potato", 0.80m),
            new Vegetable("Tomato", 1.20m),
            new Vegetable("Onion", 0.60m),
            new Vegetable("Spinach", 2.00m)
        };

        // List to store items in the cart
        List<Vegetable> cart = new List<Vegetable>();

        // Adding items to cart
        cart.Add(vegetables[0]); // Adding Carrot
        cart.Add(vegetables[2]); // Adding Tomato
        cart.Add(vegetables[4]); // Adding Spinach

        // Calculate total price using LINQ
        decimal total = cart.Sum(v => v.Price);

        // Display the total bill
        Console.WriteLine($"Total bill: ${total}");
    }
}