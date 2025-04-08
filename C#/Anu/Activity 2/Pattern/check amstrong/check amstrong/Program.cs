internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int originalNumber = number;
        int result = 0;
        int digits = number.ToString().Length;

        while (number > 0)
        {
            int digit = number % 10;
            result += (int)Math.Pow(digit, digits);
            number = number / 10;
        }

        if (result == originalNumber)
        {
            Console.WriteLine($"{originalNumber} is an Armstrong number.");
        }
        else
        {
            Console.WriteLine($"{originalNumber} is not an Armstrong number.");
        }
    }
}
