internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number;

        // Read and validate user input
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Invalid input. Please enter a valid number: ");
        }

        Console.WriteLine($"Multiplication Table for {number}:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}