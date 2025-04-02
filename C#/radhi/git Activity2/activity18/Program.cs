using System.ComponentModel;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Write a program to generate a random number and keep asking the user to guess it until 
        //    they are correct, using a do -while loop
        int number;
        do
        {
            Console.WriteLine("enter a number");
            number = Convert.ToInt32(Console.ReadLine());


        } while (number != 234);

    }
}