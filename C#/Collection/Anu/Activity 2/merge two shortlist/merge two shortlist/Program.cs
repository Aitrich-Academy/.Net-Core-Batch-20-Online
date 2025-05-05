using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merge_two_shortlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> list1 = new SortedList<int, string>
            {
                { 1, "Apple" },
                { 3, "Banana" },
                { 5, "Cherry" }
            };

            SortedList<int, string> list2 = new SortedList<int, string>
            {
                { 2, "Date" },
                { 3, "Elderberry" }, // Duplicate key
                { 6, "Fig" }
            };

            SortedList<int, string> mergedList = MergeSortedLists(list1, list2);

            Console.WriteLine("Merged SortedList (No Duplicates):");
            foreach (var item in mergedList)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        static SortedList<int, string> MergeSortedLists(SortedList<int, string> list1, SortedList<int, string> list2)
        {
            var result = new SortedList<int, string>();

            // Add all elements from list2
            foreach (var item in list2)
            {
                result[item.Key] = item.Value;
            }

            // Add elements from list1, overwriting duplicates in list2
            foreach (var item in list1)
            {
                result[item.Key] = item.Value;
            }

            return result;
        }
    }
}
        
    

