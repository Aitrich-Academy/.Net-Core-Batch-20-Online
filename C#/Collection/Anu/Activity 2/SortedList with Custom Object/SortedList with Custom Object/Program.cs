using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList_with_Custom_Object
{
    internal class Program
    {
        static SortedList<int, Student> students = new SortedList<int, Student>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- Student Management ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display Students with Grade > 80");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        DisplayHighGradeStudents();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void AddStudent()
        {
            Console.Write("Enter student ID: ");
            int id = int.Parse(Console.ReadLine());

            if (students.ContainsKey(id))
            {
                Console.WriteLine("Student ID already exists!");
                return;
            }

            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter grade: ");
            double grade = double.Parse(Console.ReadLine());

            students.Add(id, new Student(name, age, grade));
            Console.WriteLine("Student added successfully.");
        }

        static void DisplayHighGradeStudents()
        {
            Console.WriteLine("\nStudents with Grade > 80:");
            foreach (var kvp in students)
            {
                if (kvp.Value.Grade > 80)
                {
                    Console.WriteLine($"ID: {kvp.Key}, {kvp.Value}");
                }
            }
        }
    }
}
    

