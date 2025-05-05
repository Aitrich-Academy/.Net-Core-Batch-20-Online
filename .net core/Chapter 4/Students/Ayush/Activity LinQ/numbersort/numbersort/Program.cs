public class Program
{
    public static void Main(string[] args)
    {
        List<int> list = new List<int>()
        { 1,2,8,6,2,10,};

        var query = list.OrderBy(e => e);
        var query1=list.OrderByDescending(e => e);

        foreach(var item in query)
        {
            Console.WriteLine(item);
        }

    }
}