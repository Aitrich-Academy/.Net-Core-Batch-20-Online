using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        //Write a C++ program to calculate the sum of digits of a given number using a while loop
        Console.WriteLine("enter a number");
        int number=Convert.ToInt32(Console.ReadLine());
        int length = number.ToString().Length;
        int i = 0,sum=0,digit;
        while (i < length)
        {
            digit = number % 10;
            sum = digit + sum;
            number = number/10;
            i++;
        }
        Console.WriteLine(sum);
           
    }
}