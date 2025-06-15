using ConsoleApp6.Modals;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var db = new LibraryContext();

        var author1 = new Author { Name = "Arundhathi Roy" };
        var author2 = new Author { Name = "J.K. Rowling" };

        var book1 = new Book { Title = "The God of Small Things", Genre = "Psychological Fiction", Author = author1 };
        var book2 = new Book { Title = "The Ministry of Utmost Happiness", Genre = "Library Fiction", Author = author1 };
        var book3 = new Book { Title = "Harry Potter", Genre = "Fantasy", Author = author2 };

        db.authors.AddRange(author1, author2);
        db.books.AddRange(book1, book2, book3);
        db.SaveChanges();

        var bookList = db.books.Include(book => book.Author).ToList();
        foreach(var book in bookList)
        {
            Console.WriteLine("Title:" + book.Title);
            Console.WriteLine("Genre: " + book.Genre);
            Console.WriteLine("Author: " + book.Author.Name);
            Console.WriteLine("----------*-----------");
        }

    }
}