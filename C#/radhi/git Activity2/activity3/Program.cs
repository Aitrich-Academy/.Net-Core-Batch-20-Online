using System.ComponentModel;
internal class Program

{
    //   // Write a C# Sharp program that prints the multiplication table of a
    //number as input.
    private static void Main(string[] args)
    {
        Console.WriteLine("enter a number ");
        int mul = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i + "*" + mul + "=" + i * mul);
        }
    }
}