internal class Program
{
    private static void Main(string[] args)
    {
        SortedList<int, string> sortedList = new SortedList<int, string>()
        {
            { 3, "Banana" },
            { 1, "Apple" },
            { 4, "Orange" },
            { 2, "Mango" }
        };

        Console.WriteLine("Sorted by Value:");
        foreach (var pair in sortedList.OrderBy(x => x.Value))
        {
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
        }

    }
}