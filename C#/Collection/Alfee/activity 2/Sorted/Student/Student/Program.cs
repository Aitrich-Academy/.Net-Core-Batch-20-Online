using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a SortedList to store student records
        SortedList<int, string> studentRecords = new SortedList<int, string>();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add a student");
            Console.WriteLine("2. Delete a student by roll number");
            Console.WriteLine("3. Display all students");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Add a student
                    Console.Write("Enter roll number: ");
                    int rollNumber = int.Parse(Console.ReadLine());
                    Console.Write("Enter student name: ");
                    string name = Console.ReadLine();
                    studentRecords[rollNumber] = name; // Add or update student
                    Console.WriteLine("Student added successfully!");
                    break;

                case 2:
                    // Delete a student by roll number
                    Console.Write("Enter roll number to delete: ");
                    int deleteRollNumber = int.Parse(Console.ReadLine());
                    if (studentRecords.ContainsKey(deleteRollNumber))
                    {
                        studentRecords.Remove(deleteRollNumber);
                        Console.WriteLine("Student deleted successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }
                    break;

                case 3:
                    // Display all students sorted by roll number
                    Console.WriteLine("\nStudent Records (Sorted by Roll Number):");
                    foreach (var record in studentRecords)
                    {
                        Console.WriteLine($"Roll Number: {record.Key}, Name: {record.Value}");
                    }
                    break;

                case 4:
                    // Exit
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
