using System.Net.NetworkInformation;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter year");
        int year=Convert.ToInt32(Console.ReadLine());
        if (year % 4 == 0 && year % 100!=0 ||(year % 400 ==0))
        {
            Console.WriteLine(year + " is a leap year");
        }
        else
        {
            Console.WriteLine(year + " is not leap year");
        }
    }
}