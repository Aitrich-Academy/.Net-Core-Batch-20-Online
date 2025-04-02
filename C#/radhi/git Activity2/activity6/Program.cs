using System.ComponentModel;

internal class Program
{
//    1.Write a program to Print this pattern
//Input :5
//*
//* *
//* * *
//* * * *
    private static void Main(string[] args)
    {
        Console.WriteLine("enter a limit");
        int limit=Convert.ToInt32(Console.ReadLine());
        for(int i=0; i<limit; i++)
        {
           
            for(int j=0; j<=i; j++)
            {
              
             
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}