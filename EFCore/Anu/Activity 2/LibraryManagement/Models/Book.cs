using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        // Foreign key
        public int AuthorId { get; set; }

        // Navigation property: Each book has one author
        public Author Author { get; set; }
    }
}
