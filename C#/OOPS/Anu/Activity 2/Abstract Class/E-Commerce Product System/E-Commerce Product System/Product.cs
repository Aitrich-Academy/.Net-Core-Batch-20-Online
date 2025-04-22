using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Product_System
{
    public abstract class Product
    {
        public double BasePrice;

        public Product(double price)
        {
            BasePrice = price;
        }
        public abstract void GetProductDetails();
        public abstract double CalculateDiscount();

        public void ShowPrice()
        {
            Console.WriteLine("Base Price: $" + BasePrice);
        }  
    }

    class Clothing : Product
    {
        public Clothing(double price) : base(price) { }

        public override void GetProductDetails()
        {
            Console.WriteLine("Product: Clothing");
        }

        public override double CalculateDiscount()
        {
            double discount = BasePrice * 0.2;
            Console.WriteLine("Clothing Discount: $" + discount);
            return discount;
        }
    }

    public class Electronics : Product
    {
        public string Name;
        public string Brand;
        public Electronics(double price ,string name ,string brand) : base(price)
        {
            Name = name;
            Brand = brand;
        }
        public override void GetProductDetails()
        {
            Console.WriteLine($"Product: Electronics ,Name :{Name } Brand : {Brand} " );
        }

        public override double CalculateDiscount()
        {
            double discount = BasePrice * 0.1;
            Console.WriteLine("Electronics Discount: $" + discount);
            return discount;
        }
    }
}
