using LibraryManagement.Models;
using Microsoft.EntityFrameworkCore;

public class Program
{
    private static void Main(string[] args)
    {
        using (var context = new LibraryContext())
        {
            // Check if data already exists
            if (!context.Authors.Any())
            {
                var author1 = new Author { Name = "George Orwell" };
                var author2 = new Author { Name = "Jane Austen" };

                var book1 = new Book { Title = "1984", Genre = "Dystopian", Author = author1 };
                var book2 = new Book { Title = "Animal Farm", Genre = "Political Satire", Author = author1 };
                var book3 = new Book { Title = "Pride and Prejudice", Genre = "Romance", Author = author2 };

                context.Authors.AddRange(author1, author2);
                context.Books.AddRange(book1, book2, book3);

                context.SaveChanges();

                context.Database.Migrate();

                // Fetch authors with their books with eager loading
                var authors = context.Authors
                    .Include(a => a.Books)
                    .ToList();

                // Print details
                foreach (var author in authors)
                {
                    Console.WriteLine($"Author #{author.AuthorId}: {author.Name}");

                    foreach (var book in author.Books)
                    {
                        Console.WriteLine($"  • Book #{book.BookId}: \"{book.Title}\" — Genre: {book.Genre}");
                    }

                    Console.WriteLine();


                }
            }

            Console.WriteLine("Sample data inserted successfully.");
        }

    }
}
