using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int reversedNumber = 0;

        for (; number != 0; number /= 10)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
        }

        Console.WriteLine("Reversed Number: " + reversedNumber);
    }
}