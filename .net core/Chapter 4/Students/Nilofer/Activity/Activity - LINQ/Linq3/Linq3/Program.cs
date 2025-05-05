internal class Program
{
    private static void Main(string[] args)
    {
        var mixedList = new List<object> { "hi", 53, "asd", 67.89, "above" ,45};

       

        var strings = mixedList.OfType<string>();

        foreach (var s in strings)
        {
            Console.WriteLine(s);
        }

        Console.WriteLine();

        var numbers= mixedList.OfType<int>();

        foreach (var s in numbers)
        {
            Console.WriteLine(s);
        }
    }}