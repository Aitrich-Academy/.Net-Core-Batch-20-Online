internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter 3 numbers");
        int a=Convert.ToInt32(Console.ReadLine());
        int b=Convert.ToInt32(Console.ReadLine());
        int c=Convert.ToInt32(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine($"{a} is larger than {b},{c} ");
        }
        else if (b > c && b > a)
        {
            Console.WriteLine($"{b} is larger than {a},{c}");
        }
        else
        {
            Console.WriteLine($"{c} is larger than {b},{a}");
        }

    }
}