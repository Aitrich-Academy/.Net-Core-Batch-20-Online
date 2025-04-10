internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter mark for Subject 1:");
        int subject1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter mark for Subject 2:");
        int subject2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter mark for Subject 3:");
        int subject3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter mark for Subject 4:");
        int subject4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter mark for Subject 5:");
        int subject5 = Convert.ToInt32(Console.ReadLine());

        int totalMarks = subject1 + subject2 + subject3 + subject4 + subject5;
        double average = totalMarks / 5.0;

        if(average >=40)
        {
            Console.WriteLine( $"You Passed and average is : {average}% ");
        }
        else
        {
            Console.WriteLine($"You Failed and average is : {average}% ");
        }
    } 
}