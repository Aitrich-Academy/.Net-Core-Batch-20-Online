using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a SortedList to store student records
        SortedList<int, string> studentRecords = new SortedList<int, string>();

        // Sample student records
        studentRecords.Add(101, "Alice");
        studentRecords.Add(102, "Bob");
        studentRecords.Add(103, "Anna");
        studentRecords.Add(104, "Charlie");
        studentRecords.Add(105, "Amelia");

        // Display all students whose names start with 'A'
        Console.WriteLine("Students with names starting with 'A':");
        foreach (var record in studentRecords)
        {
            if (record.Value.StartsWith("A", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Roll Number: {record.Key}, Name: {record.Value}");
            }
        }
    }
}