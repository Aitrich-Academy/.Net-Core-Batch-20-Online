using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        //Write a C# program to store and display 5 integers using a single-dimensional array.
        int[] number = new int[5];
        Console.WriteLine("enter five numbers");

        for(int i = 0;i<5;i++)
        {
            number[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("display array");
        foreach (int i in number)
        {

            Console.WriteLine(i);
        }
    }
}