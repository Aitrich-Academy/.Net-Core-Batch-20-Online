using System.Diagnostics.Metrics;

internal class Program
{
    private static void Main(string[] args)
    {
        //        1.Write a C# program that prompts the user to enter a positive integer. The program should
        //repeatedly ask the user for input until a valid positive integer is entered.If the user enters a non -
        //positive integer(zero or negative), display a message asking them to enter a valid positive integer.
        int x;

        do
        {

            Console.WriteLine("enter a number");
             x = Convert.ToInt32(Console.ReadLine());
            if(x<=0)
            {
                Console.WriteLine("enter a valid +ve integer");
            }

        } while (x <= 0);



    }
}