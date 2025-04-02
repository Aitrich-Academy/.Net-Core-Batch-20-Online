using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter first number ");
        int first=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter second number");
        int second=Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine("***CAlCULATOR*** \n 1.Addition \n 2.Substraction \n 3.Multiplication \n 4.Division \n 5.Exit \n Select any operation(0-4)");
        int ch =Convert.ToInt32(Console.ReadLine());

        switch (ch)
        {

            case 1:
                Console.WriteLine($"Addition {first} + {second} =  {first + second}");
                break;
            case 2:
                Console.WriteLine($"Substraction {first} - {second} =  {first - second}");
                break;
            case 3:
                Console.WriteLine($"Multiplication {first} * {second} =  {first * second}");
                break;
            case 4:
                Console.WriteLine($"Division {first} / {second} =  {first / second}");
                break;

            default:
                Console.WriteLine("invalid ");
                break;
        }
                
              




        }
}