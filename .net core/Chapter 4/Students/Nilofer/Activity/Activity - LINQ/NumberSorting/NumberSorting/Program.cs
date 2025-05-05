internal class Program
{
    private static void Main(string[] args)
    {
        List<int> list = new List<int>()
        {
            34,78,90,65,39,82,10,9,56,88,91,23
        };

        Console.WriteLine("Numbers in Ascending order \n");
        
        var linq = list.OrderBy(x => x);

        foreach (var x in linq)
        {
            Console.WriteLine(x);
        }
        Console.WriteLine();

        Console.WriteLine("Numbers in Descending Order \n");

        var lin = list.OrderByDescending(x => x);

        foreach (var x in lin)
        {
            Console.WriteLine(x);
        }
    }
}