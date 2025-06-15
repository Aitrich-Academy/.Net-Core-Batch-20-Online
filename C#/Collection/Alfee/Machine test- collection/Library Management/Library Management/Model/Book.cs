using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Model
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int QuantityAvailable { get; set; }

        public Book(string title, string author, string iSBN, int quantityAvailable)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            QuantityAvailable = quantityAvailable;
        }
    }           
}
