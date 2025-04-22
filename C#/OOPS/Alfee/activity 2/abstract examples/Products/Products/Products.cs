using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products_oops
{
    abstract class Products
    {
        public string Name;
        public string Brand;
        public decimal BasePrice;

        public Products(string name , decimal baseprice, string brand)
        {
            Name = name;
            Brand = brand;
            BasePrice = baseprice;
        }

        public abstract void GetProductDetails();
        public abstract void CalculateDiscount();

        public void ShowPrice()
        {
            Console.WriteLine("The base price is :" + BasePrice);
        }

    }

    class Electronics : Products
    {
        public Electronics(string name, decimal baseprice, string brand) : base(name, baseprice, brand) { }

       public override void GetProductDetails()
        {
            Console.WriteLine("Electronics Name:" + Name);
            Console.WriteLine("Electronics Brand:" + Brand);

        }

        public override void CalculateDiscount()
        {
            decimal discount = BasePrice * 0.10m; 
            Console.WriteLine($"Discount: ₹{discount}, Final Price: ₹{BasePrice - discount}");
        }
    }

    class Clothing : Products
    {
        public Clothing(string name, decimal baseprice, string brand) : base(name, baseprice, brand) { }

        public override void GetProductDetails()
        {
            Console.WriteLine("Clothing Name:" + Name);
            Console.WriteLine("Clothing Brand:" + Brand);

        }

        public override void CalculateDiscount()
        {
            decimal discount = BasePrice * 0.10m;
            Console.WriteLine($"Discount: ₹{discount}, Final Price: ₹{BasePrice - discount}");
        }
    }
}
