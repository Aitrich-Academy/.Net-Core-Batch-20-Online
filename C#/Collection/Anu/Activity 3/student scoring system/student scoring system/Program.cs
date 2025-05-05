using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_scoring_system
{
    internal class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n=== Student Scoring System ===");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display All Students");
                Console.WriteLine("3. Calculate Average Score");
                Console.WriteLine("4. Rank Students");
                Console.WriteLine("5. Remove Student");
                Console.WriteLine("6. Find Student");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        DisplayStudents();
                        break;
                    case "3":
                        CalculateAverageScore();
                        break;
                    case "4":
                        RankStudents();
                        break;
                    case "5":
                        RemoveStudent();
                        break;
                    case "6":
                        FindStudent();
                        break;
                    case "7":
                        exit = true;
                        Console.WriteLine("Exiting application...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void AddStudent()
        {
            Console.WriteLine("\n-- Add Student --");

            int id = GetValidatedInt("Enter ID: ");
            if (students.Any(s => s.ID == id))
            {
                Console.WriteLine("A student with this ID already exists.");
                return;
            }

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            int age = GetValidatedInt("Enter Age: ");
            double score = GetValidatedDouble("Enter Score: ");

            students.Add(new Student { ID = id, Name = name, Age = age, Score = score });
            Console.WriteLine("Student added successfully!");
        }

        static void DisplayStudents()
        {
            Console.WriteLine("\n-- All Students --");
            if (students.Count == 0)
            {
                Console.WriteLine("No student records found.");
                return;
            }

            Console.WriteLine("ID\tName\tAge\tScore");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.ID}\t{student.Name}\t{student.Age}\t{student.Score}");
            }
        }

        static void CalculateAverageScore()
        {
            Console.WriteLine("\n-- Average Score --");
            if (students.Count == 0)
            {
                Console.WriteLine("No student records to calculate average.");
                return;
            }

            double avg = students.Average(s => s.Score);
            Console.WriteLine($"Average Score: {avg:F2}");
        }

        static void RankStudents()
        {
            Console.WriteLine("\n-- Student Rankings --");
            if (students.Count == 0)
            {
                Console.WriteLine("No student records to rank.");
                return;
            }

            var ranked = students.OrderByDescending(s => s.Score).ToList();
            Console.WriteLine("Rank\tName\tScore");
            int rank = 1;
            foreach (var student in ranked)
            {
                Console.WriteLine($"{rank++}\t{student.Name}\t{student.Score}");
            }
        }

        static void RemoveStudent()
        {
            Console.WriteLine("\n-- Remove Student --");
            int id = GetValidatedInt("Enter student ID to remove: ");

            var student = students.FirstOrDefault(s => s.ID == id);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student removed successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        static void FindStudent()
        {
            Console.WriteLine("\n-- Find Student --");
            int id = GetValidatedInt("Enter student ID to find: ");

            var student = students.FirstOrDefault(s => s.ID == id);
            if (student != null)
            {
                Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}, Score: {student.Score}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        static int GetValidatedInt(string prompt)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out value))
                    return value;
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        static double GetValidatedDouble(string prompt)
        {
            double value;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out value))
                    return value;
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
    }

