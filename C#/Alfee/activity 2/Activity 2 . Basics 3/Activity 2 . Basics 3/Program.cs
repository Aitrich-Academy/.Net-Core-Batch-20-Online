internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the fourth number: ");
        int num4 = Convert.ToInt32(Console.ReadLine());

        double average = (num1 + num2 + num3 + num4) / 4.0;

        Console.WriteLine("The average is: {4}", num1, num2, num3, num4, average);
    }
}