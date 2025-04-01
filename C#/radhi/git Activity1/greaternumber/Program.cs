internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter a two numbers");
       int first_number=Convert.ToInt32(Console.ReadLine());
        int second_number =Convert.ToInt32(Console.ReadLine());

        if (first_number > second_number)
        {
            Console.WriteLine(first_number + "is larger than" + second_number);
        }
        else
        {
            Console.WriteLine(second_number + "is larger than " + first_number);
        }
    }
}