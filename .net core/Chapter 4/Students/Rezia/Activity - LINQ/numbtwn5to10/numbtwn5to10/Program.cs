
internal class Program
{
    private static void Main(string[] args)
    {
        //    List<string> fruits = new List<string> { "Apple", "Orange", "Banana", "Grapes", "Watermelon", "Pomegranate", "Blueberry", "Jackfruit" };




        //    var linqquery = from x in fruits
        //                    where x.Contains("e")
        //                    select x;
        //    Console.WriteLine("Friuts with letter e");
        //    foreach (var n in linqquery)
        //    {
        //        Console.WriteLine(n);
        //    }

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var methodsyntaxQuery = numbers.Where(e => e < 5 && e > 10).Select(e => e);

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}