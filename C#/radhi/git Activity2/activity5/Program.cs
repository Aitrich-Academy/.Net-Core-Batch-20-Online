using System.Numerics;
using System.Runtime.Intrinsics.X86;

internal class Program
{
    ////Write a C# program that takes a number as input and displays it four
    //times in a row(separated by blank spaces), and then four times in the
    //next row, with no separation.You should do it twice: Use the console.
    private static void Main(string[] args)
    {
        Console.WriteLine("enter a digit");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0} {0} {0} {0}", input);
        Console.WriteLine("{0}{0}{0}{0}", input);
        Console.WriteLine("{0} {0} {0} {0}", input);
        Console.WriteLine("{0}{0}{0}{0}", input);
    }
}