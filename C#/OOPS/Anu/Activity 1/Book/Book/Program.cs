using Book;

internal class Program
{
    private static void Main(string[] args)
    {
        ClsBook mybook1 = new ClsBook("The Alchemist", "Paulo Coelho", 9.99);
        ClsBook mybook2 = new ClsBook("Atomic Habits", "James Clear", 14.99);
        mybook1.DisplayBookDetails();
        mybook2.DisplayBookDetails();
    }
}