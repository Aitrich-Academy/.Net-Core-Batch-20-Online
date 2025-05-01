using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Book_Management
{
    internal class Program
    {
        struct Book
        {
            public int BookID;
            public string Title;
            public string Author;
        }
        static void Main(string[] args)
        {
            const int size = 5;
            Book[] book = new Book[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"\n Enter details for Books {i + 1} :");
                Console.Write("Book ID :");
                book[i].BookID = int.Parse(Console.ReadLine());
                Console.Write("Title :");
                book[i].Title = Console.ReadLine();
                Console.Write("Author :");
                book[i].Author = Console.ReadLine();
            }

            Console.WriteLine("\n Book Details :");
            foreach (var mybook in book)
            {
                Console.WriteLine($"ID : {mybook.BookID} , Title : {mybook.Title} , Author : {mybook.Author}");
            }

            Console.Write("\nEnter Book ID to search: ");
            int searchID = int.Parse(Console.ReadLine());
            bool found = false;

            foreach (Book mybook in book)
            {
                if (mybook.BookID == searchID)
                {
                    Console.WriteLine("\nBook Found:");
                    Console.WriteLine($"Book ID: {mybook.BookID}");
                    Console.WriteLine($"Title: {mybook.Title}");
                    Console.WriteLine($"Author: {mybook.Author}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Book not found.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
    }

