internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 5, 6, 8, 10 };
        var result = from n in numbers
                     let square = n * n
                     where square > 20
                     select new {Number = n, Square = square};

        Console.WriteLine("Numbers and their squares (square > 20):");

        foreach (var item in result)
        {
            Console.WriteLine($"Number: {item.Number}, Square: {item.Square}");
        }



    }
}