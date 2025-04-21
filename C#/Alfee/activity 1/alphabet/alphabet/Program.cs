internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter any character");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
        {
            Console.WriteLine($"{ch} is an alphabet.");
        }
        else
        {
            Console.WriteLine($"{ch} is not an alphabet.");
        }
    }
}