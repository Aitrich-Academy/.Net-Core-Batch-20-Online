using System.ComponentModel;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        //Write a program to find the sum of all elements in an array using a foreach loop
        int[] numbers = { 2, 3, 4, 5 };
        int s = 0;
        foreach(int number in numbers)
            {
            
            s = s + number;


        }
        Console.WriteLine(s);
        
    }
}