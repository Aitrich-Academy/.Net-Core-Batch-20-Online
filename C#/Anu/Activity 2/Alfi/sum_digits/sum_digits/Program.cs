internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;

        while (number != 0)
        {
            sum += number % 10; // Extract the last digit and add to sum
            number /= 10; // Remove the last digit
        }

        Console.WriteLine("Sum of digits: " + sum);
    }
}