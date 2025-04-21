internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine("These are numbers");
        foreach(int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}