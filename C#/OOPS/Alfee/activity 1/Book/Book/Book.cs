using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_oops
{
    public class Book
    {
        public string Title;
        public string Author;
        public double Price;

        public void DisplayInfo()
        {
            Console.WriteLine($"Title:{Title}");
            Console.WriteLine($"Author:{Author}");
            Console.WriteLine($"Price:{Price}");
            Console.WriteLine();
        }
    }
}
