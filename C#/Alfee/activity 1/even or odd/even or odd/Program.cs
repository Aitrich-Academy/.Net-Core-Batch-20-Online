internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a number : ");
        int num = Convert.ToInt32(Console.ReadLine());

        if(num % 2 ==0)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }
       
    }
}