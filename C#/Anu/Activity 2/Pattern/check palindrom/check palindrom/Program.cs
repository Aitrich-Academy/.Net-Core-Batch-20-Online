internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int originalNumber = number;
        int reversed = 0;

        // Reverse the number
        while (number > 0)
        {
            int digit = number % 10;
            reversed = (reversed * 10) + digit;
            number = number / 10;
        }

        // Check if original and reversed are the same
        if (originalNumber == reversed)
        {
            Console.WriteLine($"{originalNumber} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{originalNumber} is not a palindrome.");
        }
    }
}
    
