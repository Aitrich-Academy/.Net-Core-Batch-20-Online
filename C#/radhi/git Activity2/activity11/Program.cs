using System.Runtime.Intrinsics.X86;

internal class Program
{
    private static void Main(string[] args)
    {
        //       1.Ask the user to input a number, then use a for loop to print the multiplication table for that
        //number(1 to 10).

        Console.WriteLine("enter a number");
        int number=Convert.ToInt32(Console.ReadLine());
        for(int i = 1;i<=10;i++)
        {
            Console.WriteLine(i + "*" + number + "=" + i * number);
                
        }

    }
}