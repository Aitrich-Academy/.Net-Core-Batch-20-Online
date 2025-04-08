internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a character: ");
        char input = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if ((input >= 'A' && input <= 'Z') || (input >= 'a' && input <= 'z'))
        {
            Console.WriteLine($"{input} is an alphabet.");
        }
        else
        {
            Console.WriteLine($"{input} is not an alphabet.");
        }
    }
}