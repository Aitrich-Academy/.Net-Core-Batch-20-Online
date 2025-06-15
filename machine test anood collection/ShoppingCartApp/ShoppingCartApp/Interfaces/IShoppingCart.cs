using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCartApp.Models;

namespace ShoppingCartApp.Interfaces
{
    public interface IShoppingCart
    {
        void AddItem(Item item);
        void RemoveItem(string itemName);
        void ApplyDiscount(decimal percentage);
        decimal CalculateTotal();
        void DisplayCart();
    }
}
