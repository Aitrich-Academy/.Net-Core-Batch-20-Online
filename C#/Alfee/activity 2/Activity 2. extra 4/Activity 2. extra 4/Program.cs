internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int originalNum = num, reverse = 0, remainder;

        while (num > 0)
        {
            remainder = num % 10;
            reverse = (reverse * 10) + remainder;
            num /= 10;
        }

        if (originalNum == reverse)
            Console.WriteLine("The number is a Palindrome.");
        else
            Console.WriteLine("The number is not a Palindrome.");
    }
}