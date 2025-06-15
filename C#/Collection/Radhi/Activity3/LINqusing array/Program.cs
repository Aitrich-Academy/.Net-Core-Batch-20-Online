internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 2, 3, 5, 6, 8, 1, 4, 7 };

        Console.WriteLine("Numbers and their squares greater than 20:");

        foreach (int num in numbers)
        {
            int square = num * num;
            if (square > 20)
            {
                Console.WriteLine($"Number: {num}, Square: {square}");
            }
        }
    }
}