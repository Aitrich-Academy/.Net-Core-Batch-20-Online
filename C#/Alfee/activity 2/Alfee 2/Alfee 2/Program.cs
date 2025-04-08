internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int sum = 0;

        while (num > 0)
        {
            sum += num % 10;  // Add the last digit to sum
            num /= 10;         // Remove the last digit
        }

        Console.WriteLine("Sum of digits: " + sum);
    }
}