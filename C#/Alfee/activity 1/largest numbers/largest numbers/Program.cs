internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter first number :");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number :");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if(num1 > num2)
        {
            Console.WriteLine("The largest number is :"+ num1);
        }
        else
        {
            Console.WriteLine("The largest number is :" + num2);
        }
    }
}