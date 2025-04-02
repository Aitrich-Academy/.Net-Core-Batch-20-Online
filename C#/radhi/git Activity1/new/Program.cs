using System.Xml.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        //int[] numbers = { 1, 2, 3, 4, 5 };

        //Console.WriteLine("these are array elements");
        //foreach (int number in numbers)
        //{
        //    Console.WriteLine(number);
        //}
        //int i = 1;
        //while(i<=10)
        //{
        //    Console.WriteLine(i);
        //    i++;
        //}

        //int number;
        //do
        //{
        //    Console.WriteLine("enter a number");
        //    number = Convert.ToInt32(Console.ReadLine());

        //}while (number >0);
        //Console.WriteLine("Thank you");
        string c;
        do
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("do you want to continue");
           c = Console.ReadLine();
        } while(c != "no");
        Console.WriteLine("end progrm");





    }
}