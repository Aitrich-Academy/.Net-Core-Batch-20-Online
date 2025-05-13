using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // First SortedList
        SortedList<int, string> list1 = new SortedList<int, string>
        {
            { 101, "Alice" },
            { 102, "Bob" },
            { 103, "Charlie" }
        };

        // Second SortedList
        SortedList<int, string> list2 = new SortedList<int, string>
        {
            { 104, "David" },
            { 105, "Bob" }, // Duplicate value "Bob"
            { 106, "Eve" }
        };

        // Merge the lists and remove duplicates
        SortedList<int, string> mergedList = new SortedList<int, string>(list1);

        // Add elements from the second list, only if the value doesn't already exist
        foreach (var record in list2)
        {
            if (!mergedList.ContainsValue(record.Value))
            {
                mergedList.Add(record.Key, record.Value);
            }
        }

        // Display the merged list
        Console.WriteLine("Merged SortedList without duplicates:");
        foreach (var record in mergedList)
        {
            Console.WriteLine($"Roll Number: {record.Key}, Name: {record.Value}");
        }
    }
}