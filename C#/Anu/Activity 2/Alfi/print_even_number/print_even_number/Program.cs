internal class Program
{
    private static void Main(string[] args)
    {

        int number = 2; // Start with the first even number

        do
        {
            Console.WriteLine(number);
            number += 2; // Increment by 2 to get the next even number
        } while (number <= 20);
    }
}