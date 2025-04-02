internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int mark=Convert.ToInt32(Console.ReadLine());
        if(mark >=30)
        {
            Console.WriteLine("A grade");

        }
        else if(mark>=20)
        {
            Console.WriteLine("B garde");

        }
        else
        {
            Console.WriteLine("failed");
        }
    }
}