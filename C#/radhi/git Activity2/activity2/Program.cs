using System.ComponentModel;

internal class Program
{
    //Write a C# Sharp program to swap two numbers.
    private static void Main(string[] args)
    {
        Console.WriteLine("enter two numbers for swap");
        int first_number = Convert.ToInt32(Console.ReadLine());
        int second_number= Convert.ToInt32(Console.ReadLine());
        int swap = second_number;
        second_number = first_number;
        Console.WriteLine(swap+ " " + second_number);
    }
}