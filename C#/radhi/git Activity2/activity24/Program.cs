using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        //Write a C++ program to print even numbers from 2 to 20 using a do -while loop
        int n = 2;
        do
        {
            if (n % 2 == 0)
            {
                Console.WriteLine(n);
            }

            n++;
        } while (n <= 20);
    }
}