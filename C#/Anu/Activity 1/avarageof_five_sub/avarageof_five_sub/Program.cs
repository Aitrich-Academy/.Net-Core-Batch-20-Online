internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter marks for Subject 1: ");
        int subject1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Subject 2: ");
        int subject2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Subject 3: ");
        int subject3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Subject 4: ");
        int subject4 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Subject 5: ");
        int subject5 = Convert.ToInt32(Console.ReadLine());

        // Calculate total and average
        int totalMarks = subject1 + subject2 + subject3 + subject4 + subject5;
        double average = totalMarks / 5.0;

        // Check if passed or failed
        if (average >= 40)
        {
            Console.WriteLine($"You Passed! Average: {average}%");
        }
        else
        {
            Console.WriteLine($"You Failed. Average: {average}%");
        }
    }
}