internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a digit: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0} {0} {0} {0}", num);
        Console.WriteLine("{0}{0}{0}{0}", num);
        Console.WriteLine("{0} {0} {0} {0}", num);
        Console.WriteLine("{0}{0}{0}{0}", num);
    }
}