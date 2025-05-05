using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Interface;

namespace ShoppingCart.Repository
{
    public class DiscountRepository : IDiscountInterface
    {
        private List<Shopping_Cart> _cartList;

        public DiscountRepository(List<Shopping_Cart> cartList)
        {
            _cartList = cartList;
        }

        public DiscountRepository()
        {
        }

        public double Discount(double percentage)
        {
            double totalPrice = _cartList.Sum(e => e.Quantity * e.Price);
            double disc_Amt = (percentage / 100) * totalPrice;
            double discount_Total = totalPrice - disc_Amt;

            Console.WriteLine("Total Price Before Discount: {0}", totalPrice);
            Console.WriteLine("Discount Applied ({0}%)    : {1}", percentage, disc_Amt);
            Console.WriteLine("Total Price After Discount : {0}", discount_Total);

            return discount_Total;
        }


        public Shopping_Cart find(int id)
        {
            var item = _cartList.FirstOrDefault(e => e.Id == id);

            if (item == null)
            {
                throw new Exception($"Item with ID {id} not found.");
            }

            return item;
        }

        public void Add(Shopping_Cart item)
        {
            _cartList.Add(item);
        }

        public void showCart()
        {
            foreach (var item in _cartList)
            {
                Console.WriteLine("Product :{0} Price :{1} Quantity :{2} Total Price :{3}",
                    item.Name,
                    item.Price,
                    item.Quantity,
                    item.Quantity * item.Price);
            }
        }
      
       public void RemoveItem(int id)
        {
            var item = find(id);
            _cartList.Remove(item);
            Console.WriteLine($"Item with ID {id} has been removed from the cart.");
        }
    }

}


