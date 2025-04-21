internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine().ToLower(); // Convert to lowercase for easy comparison

        int vowelCount = 0;
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        foreach (char ch in input)
        {
            if (Array.Exists(vowels, element => element == ch))
            {
                vowelCount++;
            }
        }

        Console.WriteLine("Number of vowels: " + vowelCount);
    }
}