using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopping_cart_using_List
{
    public  class Shopping
    {
        ArrayList items = new ArrayList();
        
      

        public void Addingitem()
        {
           

            Console.Write("Enter the number of items: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter name of item {i + 1}: ");
                 string name = Console.ReadLine();

                Console.Write($"Enter price of {name}: ");
                int price =Convert.ToInt32(Console.ReadLine());

                items.Add(new object[] {name,price});
            }
        }

        public void Carttotalprice()
        {
            int total = 0; // total price variable

            foreach (object[] item in items)
            {
                string name = (string)item[0];
                int price = (int)item[1];
                Console.WriteLine($"Item: {name}, Price: {price}");
                total += price;
            }

            Console.WriteLine($"\nTotal Price: {total}");
        }
        





    }
}
