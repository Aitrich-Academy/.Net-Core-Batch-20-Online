using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
//        5.Write a program using a for loop to iterate through numbers from 1 to 50.
//Print & quot; Fizz & quot; if the number is divisible by 3.
//        Print & quot; Buzz & quot; if the number is divisible by 5.
//Print & quot; FizzBuzz & quot; if the number is divisible by both 3 and 5.
//Otherwise, print the number.

        for(int num = 1;num<=50;num++)
        {
            if (num % 3 == 0 && num % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (num % 3 == 0)
                Console.WriteLine("Fizz");
            else if (num % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(num);


        }




    }


}