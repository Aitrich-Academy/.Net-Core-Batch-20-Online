internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        (a, b) = (b, a);

        Console.WriteLine("After Swapping:");
        Console.WriteLine("First Number: " + a);
        Console.WriteLine("Second Number: " + b);


    }
}