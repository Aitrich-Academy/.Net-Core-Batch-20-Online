internal class Program
{
    private static void Main(string[] args)
    {
        int number;

        do
        {
            Console.Write("Enter a positive integer: ");
            if (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive integer.");
            }
        } while (number <= 0);

        Console.WriteLine("You entered a valid positive integer: " + number);
    }
}