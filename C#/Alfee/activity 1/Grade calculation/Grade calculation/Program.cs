internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your marks:");
        int marks = Convert.ToInt32(Console.ReadLine());

        if(marks >= 90)
        {
            Console.WriteLine("Your grade is: A");
        }
        else if (marks >= 80)
        {
            Console.WriteLine("Your grade is: B");
        }
        else if (marks >= 70)
        {
            Console.WriteLine("Your grade is: C");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("Your grade is: D");
        }
        else if (marks >= 50)
        {
            Console.WriteLine("Your grade is: E");
        }
        else
        {
            Console.WriteLine("Your grade is: F");
        }
    }
}