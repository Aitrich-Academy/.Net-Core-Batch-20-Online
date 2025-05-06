using System.Runtime.InteropServices;
using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        Studentdetails s = new Studentdetails();
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\n--- Student Scoring System ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display All Students");
            Console.WriteLine("3. Calculate Average Score");
            Console.WriteLine("4. Rank Students");
            Console.WriteLine("5. Remove Student");
            Console.WriteLine("6. Find a Student");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice (1-7): ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": s.Addstudent(); break;
                case "2": s.Displaystudent(); break;
                case "3": s.CalculateAverage(); break;
                case "4":; s.Rank(); break;
                case "5": s.RemoveStudent(); break;
                case "6": s.FindStudent(); break;
                case "7": exit = true; Console.WriteLine("Exiting..."); break;
                default: Console.WriteLine("Invalid choice. Please enter a number between 1 and 7."); break;
            }
        }
    }
}