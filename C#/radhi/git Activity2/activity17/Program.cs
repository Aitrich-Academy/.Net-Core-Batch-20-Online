using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Write a program to count the number of digits in a given number using a for loop
        int count = 0;
        Console.WriteLine("enter a number");
        int number=Convert.ToInt32(Console.ReadLine());

        if (number == 0)
        {

            count = 0;
        }

        for (; number > 0; number =number/10)
        {
            count++;
        }
        Console.WriteLine("Number of digits: " + count);





    }
}