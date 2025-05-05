using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Student_Records_using_SortedList
{
    internal class Program
    {
        static SortedList<int, string> studentRecords = new SortedList<int, string>();
        static void Main(string[] args)
        {
            

            int choice;

            do
            {
                Console.WriteLine("\n--- Student Records Menu ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Delete Student by Roll Number");
                Console.WriteLine("3. Display All Students");
                Console.WriteLine("4. Display Students with Names Starting with 'A'");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        DeleteStudent();
                        break;
                    case 3:
                        DisplayAllStudents();
                        break;
                    case 4:
                        DisplayStudentsWithA();
                        break;
                    case 5:
                        Console.WriteLine("Exiting the program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Choose again.");
                        break;
                }
            } while (choice != 5);
        }

        static void AddStudent()
        {
            Console.Write("Enter roll number (int): ");
            if (!int.TryParse(Console.ReadLine(), out int roll))
            {
                Console.WriteLine("Invalid roll number.");
                return;
            }

            if (studentRecords.ContainsKey(roll))
            {
                Console.WriteLine("Roll number already exists.");
                return;
            }

            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            studentRecords.Add(roll, name);
            Console.WriteLine("Student added successfully.");
        }

        static void DeleteStudent()
        {
            Console.Write("Enter roll number to delete: ");
            if (!int.TryParse(Console.ReadLine(), out int roll))
            {
                Console.WriteLine("Invalid roll number.");
                return;
            }

            if (studentRecords.Remove(roll))
                Console.WriteLine("Student removed successfully.");
            else
                Console.WriteLine("Roll number not found.");
        }

        static void DisplayAllStudents()
        {
            if (studentRecords.Count == 0)
            {
                Console.WriteLine("No students to display.");
                return;
            }

            Console.WriteLine("\n--- Student List ---");
            foreach (var kvp in studentRecords)
            {
                Console.WriteLine($"Roll No: {kvp.Key}, Name: {kvp.Value}");
            }
        }

        static void DisplayStudentsWithA()
        {
            var filtered = studentRecords.Where(kvp => kvp.Value.StartsWith("A", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("\n--- Students with Names Starting with 'A' ---");
            foreach (var kvp in filtered)
            {
                Console.WriteLine($"Roll No: {kvp.Key}, Name: {kvp.Value}");
            }

            if (!filtered.Any())
                Console.WriteLine("No students found with names starting with 'A'.");
        }
    }

}
   
