
internal class Program
   
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Console.Write("Alfee");
        //Console.Write("Welcome to c++");
        //Console.WriteLine("Hello All!");
        Console.Write("enter any name?");
        string name = Console.ReadLine();
        Console.WriteLine($" My name is :{name}");
        Console.WriteLine("enter any age?");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($" My AGE is :{age}");

        if (age>=18)
        {
            Console.WriteLine("eligible for voting");
        }
        else
        {
            Console.WriteLine(" not eligible for voting");
        }


    }
}