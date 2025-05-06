
   using System;
using System.Collections.Generic;

public class SortedListMerger
{
    public static SortedList<int, string> MergeSortedLists(SortedList<int, string> list1, SortedList<int, string> list2)
    {
        SortedList<int, string> mergedList = new SortedList<int, string>();

        // Add all elements from the first list
        foreach (var kvp in list1)
        {
            mergedList[kvp.Key] = kvp.Value;
        }

        // Add elements from the second list if the key does not already exist
        foreach (var kvp in list2)
        {
            if (!mergedList.ContainsKey(kvp.Key))
            {
                mergedList.Add(kvp.Key, kvp.Value);
            }
        }

        return mergedList;
    }

    // Test example
    public static void Main()
    {
        var list1 = new SortedList<int, string>
        {
            {1, "One"},
            {3, "Three"},
            {5, "Five"}
        };

        var list2 = new SortedList<int, string>
        {
            {2, "Two"},
            {3, "Three - Duplicate"},
            {6, "Six"}
        };

        var merged = MergeSortedLists(list1, list2);

        foreach (var kvp in merged)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
