internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter a character");
        char ch = Console.ReadKey().KeyChar;
        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
        {
            Console.WriteLine("  is a vowel");
        }
        else
        {
            Console.WriteLine("  is not vowel");      
        }
    }
}