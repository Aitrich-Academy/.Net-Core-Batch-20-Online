
using Book_oops;

internal class Program
{
    private static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.Title = "The Alchemist";
        book1.Author = "Paulo Coelho";
        book1.Price = 9.99;

        Book book2 = new Book();
        book2.Title = "Atomic Habits";
        book2.Author = "James Clear";
        book2.Price = 14.99;

        Console.WriteLine("Book 1:");
        book1.DisplayInfo();

        Console.WriteLine("Book 2:");
        book2.DisplayInfo();
    }
}