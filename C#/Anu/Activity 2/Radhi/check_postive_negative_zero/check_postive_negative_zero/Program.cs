internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        switch (Math.Sign(number))
        {
            case 1:
                Console.WriteLine("The number is Positive.");
                break;
            case -1:
                Console.WriteLine("The number is Negative.");
                break;
            case 0:
                Console.WriteLine("The number is Zero.");
                break;
            default:
                Console.WriteLine("Invalid input.");
                break;
        }
    }
}