internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter your marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());

        string grade;

        if (marks >= 90)
            grade = "A+";
        else if (marks >= 80)
            grade = "A";
        else if (marks >= 70)
            grade = "B";
        else if (marks >= 60)
            grade = "C";
        else if (marks >= 50)
            grade = "D";
        else
            grade = "F";

        Console.WriteLine($"Your grade is: {grade}");
    }
}