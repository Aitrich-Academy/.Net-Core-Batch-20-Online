using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double Score { get; set; }

    public Student(int id, string name, double score)
    {
        ID = id;
        Name = name;
        Score = score;
    }
}

class Program
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display All Students");
            Console.WriteLine("3. Calculate Average Score");
            Console.WriteLine("4. Rank Students");
            Console.WriteLine("5. Remove a Student");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1") AddStudent();
            else if (choice == "2") DisplayAllStudents();
            else if (choice == "3") CalculateAverageScore();
            else if (choice == "4") RankStudents();
            else if (choice == "5") RemoveStudent();
            else if (choice == "6") return;
            else Console.WriteLine("Invalid choice.");
        }
    }

    // Add a student
    static void AddStudent()
    {
        Console.Write("Enter Student ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Student Score: ");
        double score = double.Parse(Console.ReadLine());
        students.Add(new Student(id, name, score));
    }

    // Display all students
    static void DisplayAllStudents()
    {
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Score: {student.Score}");
        }
    }

    // Calculate average score
    static void CalculateAverageScore()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students available.");
            return;
        }
        double average = students.Average(s => s.Score);
        Console.WriteLine($"Average Score: {average}");
    }

    // Rank students by score
    static void RankStudents()
    {
        var ranked = students.OrderByDescending(s => s.Score).ToList();
        int rank = 1;
        foreach (var student in ranked)
        {
            Console.WriteLine($"Rank {rank++}: {student.Name} - Score: {student.Score}");
        }
    }

    // Remove a student by ID
    static void RemoveStudent()
    {
        Console.Write("Enter the Student ID to remove: ");
        int id = int.Parse(Console.ReadLine());
        var student = students.FirstOrDefault(s => s.ID == id);
        if (student != null)
        {
            students.Remove(student);
            Console.WriteLine("Student removed.");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }
}
