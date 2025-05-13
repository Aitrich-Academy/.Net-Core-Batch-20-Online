using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create a SortedList with int keys and string values
        SortedList<int, string> studentRecords = new SortedList<int, string>
        {
            { 101, "Alice" },
            { 102, "Bob" },
            { 103, "Charlie" },
            { 104, "David" }
        };

        // Display the original SortedList
        Console.WriteLine("Original SortedList (sorted by keys):");
        foreach (var record in studentRecords)
        {
            Console.WriteLine($"Roll Number: {record.Key}, Name: {record.Value}");
        }

        // Sort the SortedList by value (student names)
        var sortedByValue = studentRecords
            .ToList()
            .OrderBy(record => record.Value)  // Sort by value
            .ToList();

        // Display the SortedList sorted by value
        Console.WriteLine("\nSorted by value (Names):");
        foreach (var record in sortedByValue)
        {
            Console.WriteLine($"Roll Number: {record.Key}, Name: {record.Value}");
        }
    }
}