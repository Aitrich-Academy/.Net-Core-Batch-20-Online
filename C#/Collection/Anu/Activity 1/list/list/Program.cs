using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to enter 5 names and store them in a List<string>
            List<string> namesList = new List<string>();
            Console.WriteLine("Enter 5 names:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Name {i + 1}: ");
                string name = Console.ReadLine();
                namesList.Add(name);
            }

            //Copy all names into an ArrayList
            ArrayList namesArrayList = new ArrayList();
            foreach (var name in namesList)
            {
                namesArrayList.Add(name);
            }

            //Create a Dictionary<int, string>

            Dictionary<int, string> namesDictionary = new Dictionary<int, string>();
            int key = 1;
            foreach (var name in namesList)
            {
                namesDictionary.Add(key, name);
                key++;
            }

            // Create a Hashtable
            Hashtable namesHashtable = new Hashtable();
            foreach (var name in namesList)
            {
                namesHashtable.Add(name, name.Length);
            }

            // Display all elements

            Console.WriteLine("\nList<string> contents:");
            foreach (var name in namesList)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nArrayList contents:");
            foreach (var name in namesArrayList)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nDictionary<int, string> contents:");
            foreach (var pair in namesDictionary)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }

            Console.WriteLine("\nHashtable contents:");
            foreach (DictionaryEntry entry in namesHashtable)
            {
                Console.WriteLine($"Key: {entry.Key}, Value (Length): {entry.Value}");
            }

        }
    }
}
