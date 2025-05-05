internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int>() {9,5,11,34,22,54,37,97,23,61 };

        var num = numbers.GroupBy(x => x % 2 == 0 ? "Even" : "Odd");

        foreach (var x in num)
        {
            Console.WriteLine($" Numbers in each category : { x.Key}");
            foreach (var y in x)
            {
                Console.WriteLine(y);
            }
               
        }
    }
}