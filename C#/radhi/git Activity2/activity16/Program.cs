using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        // Write a program to remove all even digits from a given number using a while loop

        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine()); 
        int result = 0, multiplier = 1;

        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 != 0) 
            {
                result += digit * multiplier;
                multiplier *= 10;
            }
            number= number / 10;
        }

        Console.WriteLine($"Number after removing even digits: {result}");
    }


}
