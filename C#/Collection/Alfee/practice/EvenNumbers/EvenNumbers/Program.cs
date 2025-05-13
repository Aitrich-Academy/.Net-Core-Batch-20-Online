class Program
{
    static void Main()
    {
        int[] numbers = { 1, 4, 7, 10, 15, 18, 21 };

        // LINQ query to select even numbers
        var evenNumbers = from num in numbers
                          where num % 2 == 0
                          select num;

        Console.WriteLine("Even Numbers:");
        foreach (var n in evenNumbers)
        {
            Console.WriteLine(n);
        }
    }
}