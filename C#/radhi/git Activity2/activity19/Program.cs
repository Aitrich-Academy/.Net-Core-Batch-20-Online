using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        //Write a program to classify a given number as positive, negative, or zero using a switch statement.

        Console.WriteLine("enter a number");
        int a=Convert.ToInt32(Console.ReadLine());

        switch(a)
        {
            case > 0:
                Console.WriteLine("The number is positive.");
                break;
            case < 0:
                Console.WriteLine("The number is negative.");
                break;
            default:
                Console.WriteLine("The number is zero.");
                break;

        }

    }
}