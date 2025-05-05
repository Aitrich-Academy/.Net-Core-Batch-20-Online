using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class Shoppingcartitem
    {
        public string Itemname {  get; set; }
        private decimal price;
            
     public int Quantity { get; set; }

        public Shoppingcartitem() { }

       public Shoppingcartitem(string name, decimal price, int quantity)
        {

            Itemname = name;
         this.price = price;
            Quantity = quantity;

        }
        public  decimal Price
        { get { return price; } 
            private set { 
            if (Price < 0)
                {
                    throw new ArgumentException("Price should be positive");
                }
            } 
        }
        
       public decimal TotalPrice()
        {
            return  Price * Quantity;
        }

        
    }
}
