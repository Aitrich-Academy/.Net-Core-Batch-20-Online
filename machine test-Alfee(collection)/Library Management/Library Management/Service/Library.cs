using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management.Model;

namespace Library_Management.Service
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            var existingBook = books.Find(b => b.ISBN == book.ISBN);
            if (existingBook != null)
            {
                existingBook.QuantityAvailable += book.QuantityAvailable;
            }
            else
            {
                books.Add(book);
            }
        }

        public void RemoveBook(string isbn)
        {
            var book = books.Find(b => b.ISBN == isbn);
            if(book == null)
            {
                throw new Exception("Book you are searching is not found");
            }
            books.Remove(book);
        }

        public void BorrowBook(string isbn)
        {
            var book = books.Find(b => b.ISBN == isbn);
            if (book == null)
            {
                throw new Exception("Book you are searching is not found");
            }
            else if(book.QuantityAvailable > 0)
            {
                book.QuantityAvailable--;
            }
            else
            {
                throw new Exception("Book your are searching is out of stock");
            }
        }

        public void DisplayBooks()
        {
            if(books.Count==0)
            {
                Console.WriteLine("No books available here.");
            }
            else
            {
                Console.WriteLine("Available books in this library are:");
                foreach (var book in books)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Copies: {book.QuantityAvailable}");
                }
            }
        }
    }
}
