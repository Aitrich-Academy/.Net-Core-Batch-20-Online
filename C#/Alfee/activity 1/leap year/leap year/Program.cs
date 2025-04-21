internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter any year :");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year % 4 ==0 && year % 100 ==0)
        {
            Console.WriteLine( year + "is leap year");
        }
        else
        {
            Console.WriteLine(year + "is not a leap year");
        }
    }
}