using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Write a C++ program to reverse a number using a for loop

        Console.WriteLine("enter a number");
        int number = Convert.ToInt32(Console.ReadLine());
        int length = number.ToString().Length;
        int digit=0, reverse = 0;


        for (int i = 0; i < length; i++)
        {
            digit = number % 10;
            reverse = reverse * 10 + digit;
            number = number / 10;
        }
        Console.WriteLine(reverse);

    }
}