using Palindrom;

internal class Program
{
    private static void Main(string[] args)
    {
        PalindromChecker checker = new PalindromChecker();
        Console.WriteLine("enter a string to check palindrom");
        string test = Console.ReadLine();
        if (checker.IsPalindrome(test))
            Console.WriteLine($"\"{test}\" is a palindrome.");
        else
            Console.WriteLine($"\"{test}\" is not a palindrome.");

    }
}