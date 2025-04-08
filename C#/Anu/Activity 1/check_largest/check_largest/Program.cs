internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
            Console.WriteLine($"{num1} is the largest number.");
        else
            Console.WriteLine($"{num2} is the largest number.");
    }
}