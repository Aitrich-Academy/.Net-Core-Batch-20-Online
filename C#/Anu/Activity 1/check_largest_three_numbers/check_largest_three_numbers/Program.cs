internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int largest;

        // Compare numbers using if-else
        if (num1 >= num2 && num1 >= num3)
        {
            largest = num1;
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            largest = num2;
        }
        else
        {
            largest = num3;
        }

        // Display the largest number
        Console.WriteLine($"The largest number is: {largest}");
    }
}
