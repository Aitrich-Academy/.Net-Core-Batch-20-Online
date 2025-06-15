using Library_Management.Model;
using Library_Management.Service;


namespace LibraryManagementSystem.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Library = new Library();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("----------*Welcome to Library Management System----------*");
                Console.WriteLine("1.Add Book");
                Console.WriteLine("2.Remove Book");
                Console.WriteLine("3.Borrow Book");
                Console.WriteLine("4.Display Book");
                Console.WriteLine("5.Select any of the options:");
                string options = Console.ReadLine();

                switch (options)
                {
                    case "1":
                        AddBook(Library);
                        break;

                    case "2":
                        RemoveBook(Library);
                        break;

                    case "3":
                        BorrowBook(Library);
                        break;

                    case "4":
                        Library.DisplayBooks();
                        break;

                    case "5":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("You had entered invalid option.Please try again.");
                        break;
                }
                if (!exit)
                {
                    Console.WriteLine("Please enter to continue with this.");
                    Console.ReadLine();
                }
            }
        }

        static void AddBook(Library library)
        {
            Console.Write("Enter the title of the book:");
            string title = Console.ReadLine();
            Console.Write("Enter the author of the book:");
            string author = Console.ReadLine();
            Console.Write("Enter the ISBN of the book:");
            string isbn = Console.ReadLine();
            Console.Write("Enter the quantity of the book:");
            int quantity = int.Parse(Console.ReadLine());

            var book = new Book(title, isbn, author, quantity);
            library.AddBook(book);
            Console.WriteLine("Book is added successfully");
        }

        static void RemoveBook(Library library)
        {
            Console.Write("Enter ISBN of the book to remove from this: ");
            string isbn = Console.ReadLine();

            try
            {
                library.RemoveBook(isbn);
                Console.WriteLine("Book is removed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void BorrowBook(Library library)
        {
            Console.Write("Enter ISBN of the book to borrow: ");
            string isbn = Console.ReadLine();

            try
            {
                library.BorrowBook(isbn);
                Console.WriteLine("Book borrowed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}


   
  

   