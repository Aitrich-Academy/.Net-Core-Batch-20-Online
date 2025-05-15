using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCartApp.Interfaces;
using ShoppingCartApp.Exceptions;

namespace ShoppingCartApp.Models
{
    public class ShoppingCart : IShoppingCart
    {
        private readonly List<Item> _items = new List<Item>();
        private decimal _discountPercentage = 0;

        public void AddItem(Item item)
        {
            var existingItem = _items.FirstOrDefault(i => i.Name.Equals(item.Name, StringComparison.OrdinalIgnoreCase));
            if (existingItem != null)
            {
                existingItem.AddQuantity(item.Quantity);
            }
            else
            {
                _items.Add(item);
            }
        }

        public void RemoveItem(string itemName)
        {
            var item = _items.FirstOrDefault(i => i.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
            if (item == null)
                throw new ItemNotFoundException(itemName);
            _items.Remove(item);
        }

        public decimal CalculateTotal()
        {
            var total = _items.Sum(i => i.TotalPrice);
            var discountAmount = total * (_discountPercentage / 100);
            var finalTotal = total - discountAmount;
            return finalTotal >= 0 ? finalTotal : 0;
        }

        public void ApplyDiscount(decimal percentage)
        {
            if (percentage < 0 || percentage > 100)
                throw new ArgumentException("Discount percentage must be between 0 and 100.");
            _discountPercentage = percentage;
        }

        public void DisplayCart()
        {
            if (!_items.Any())
            {
                Console.WriteLine("Your cart is empty.");
                return;
            }

            Console.WriteLine("\nItems in your cart:");
            foreach (var item in _items)
            {
                Console.WriteLine($"- {item.Name}: {item.Quantity} x {item.Price:C} = {item.TotalPrice:C}");
            }
            Console.WriteLine($"Total (after {_discountPercentage}% discount): {CalculateTotal():C}\n");
        }
    }
}
