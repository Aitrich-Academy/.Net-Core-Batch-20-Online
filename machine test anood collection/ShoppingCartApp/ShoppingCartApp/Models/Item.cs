using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShoppingCartApp.Models
{
    public class Item
    {
        public string Name { get; }
        public decimal Price { get; }
        public int Quantity { get; private set; }

        public Item(string name, decimal price, int quantity)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Item name cannot be empty.");
            if (price < 0)
                throw new ArgumentException("Price cannot be negative.");
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be at least 1.");

            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void AddQuantity(int amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be positive.");
            Quantity += amount;
        }

        public void RemoveQuantity(int amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be positive.");
            if (amount > Quantity)
                throw new InvalidOperationException("Cannot remove more than existing quantity.");
            Quantity -= amount;
        }

        public decimal TotalPrice => Price * Quantity;
    }
}
