internal class Program
{
    private static void Main(string[] args)
    {
        Stack<string> books = new Stack<string>();

        //push is used to add elements
        books.Push("C# Basics");
        books.Push("OOP Concepts");
        books.Push("Collections");
        books.Push("Linux");

        //peak is used to check top elements
        Console.WriteLine($"Top book is:{books.Peek()}");

        //pop is used to remove elements
        Console.WriteLine($"Next book is:{books.Pop()}");
        Console.WriteLine($"Next book is:{books.Pop()}");

        Console.WriteLine($"Top book is:{books.Peek()}");

        //count is used to check remaining elements
        Console.WriteLine($"Book remaining are:{books.Count()}");


    }
}