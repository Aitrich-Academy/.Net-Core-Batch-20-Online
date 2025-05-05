using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Interface
{
    public interface IDiscountInterface
    {
        public double Discount(double percentage);
        public Shopping_Cart find(int i);
        public void Add(Shopping_Cart item);

        public void showCart();
        public void RemoveItem(int id);
    }
}
