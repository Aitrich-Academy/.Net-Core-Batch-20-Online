internal class Program
{
    private static void Main(string[] args)
    {

        Console.Write("Enter a number : ");
        int num;
        if (int.TryParse(Console.ReadLine(), out num))
        {
            if (num % 2 == 0)

            {
                Console.WriteLine($"{num} is Even.");
            }

            else
            {
                Console.WriteLine($"{num} is Odd.");
            }

        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid integer.");
        }
    }
}