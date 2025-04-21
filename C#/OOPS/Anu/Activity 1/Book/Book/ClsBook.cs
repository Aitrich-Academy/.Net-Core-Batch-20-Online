using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class ClsBook
    {
        public string Title;
        public string Author;
        public double Price;

        public ClsBook(string mytitle,string myauthor,double myprice)
        {
            Title = mytitle;
            Author = myauthor;  
            Price = myprice;
        }
        public void DisplayBookDetails()
        {
            Console.WriteLine($"/n Book Details :");
            Console.WriteLine($"The Title of the book is:{Title}");
            Console.WriteLine($"The Author of the book is: {Author}");
            Console.WriteLine($"Prize of the Book is :{Price}");
        }


    }
}
 