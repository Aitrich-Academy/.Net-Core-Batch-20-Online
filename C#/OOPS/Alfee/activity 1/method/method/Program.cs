using method_oops;
internal class Program
{
    private static void Main(string[] args)
    {
        Method book1 = new Method();
        book1.Title = "The Alchemist";
        book1.Author = "Paulo Coelho";
        book1.Price = 9.99;

        Method book2 = new Method();
        book2.Title = "Atomic Habits";
        book2.Author = "James Clear";
        book2.Price = 14.99;

        Console.WriteLine("Book 1:");
        Console.WriteLine("Title: + book1.Title");
        Console.WriteLine("Author: + book1.Author");
        Console.WriteLine("Price: $ + book1.Price");


        Console.WriteLine("Book 2:");
        Console.WriteLine("Title: + book2.Title");
        Console.WriteLine("Author: + book2.Author");
        Console.WriteLine("Price: $ + book2.Price");


    }
}