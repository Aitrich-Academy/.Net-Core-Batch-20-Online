public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int a = Convert.ToInt32(Console.ReadLine());
        if(a % 2==0)
        {
            Console.WriteLine(" number is even");
        }
        else
        {
            Console.WriteLine("number is odd");
        }
    }
}