using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_by_Value_Instead_of_Key
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(3, "Banana");
            sortedList.Add(1, "Apple");
            sortedList.Add(4, "Cherry");
            sortedList.Add(2, "Date");

            Console.WriteLine("Original SortedList (by key):");
            foreach (var kvp in sortedList)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            Console.WriteLine("\nSorted by Value:");
            foreach (var kvp in sortedList.OrderBy(kvp => kvp.Value))
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            Console.ReadLine();
        }
    }
    }

