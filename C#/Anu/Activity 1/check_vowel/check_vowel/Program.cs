internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a character: ");
        char input = Char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        if (IsVowel(input))
        {
            Console.WriteLine($"{input} is a vowel.");
        }
        else
        {
            Console.WriteLine($"{input} is not a vowel.");
        }
    }

    static bool IsVowel(char c)
    {
        return "aeiou".Contains(c);
    }
}
