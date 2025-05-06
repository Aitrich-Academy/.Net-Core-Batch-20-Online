
using static System.Formats.Asn1.AsnWriter;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //// Ask the user to enter 5 names and store them in a List<string>
        List<string> Name = new List<string>();
        Console.WriteLine("enter 5 Names");

        for (int i = 0; i < 5; i++)
        {

            Name.Add(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("view all list elements");
        Console.WriteLine("------------");
        foreach (string s in Name)
        {
            Console.WriteLine(s);
        }

        //// Copy all the names from the List into an ArrayList
        ArrayList names = new ArrayList();
        Console.WriteLine();

        Console.WriteLine("Array List");
        Console.WriteLine("______________");

        foreach (string s in Name)
        {
            names.Add(s);
        }
        foreach (string s in names)
        {
            Console.WriteLine(s);
        }


        Console.WriteLine("------------------------------------------------");
        // Create a Dictionary<int, string> where:
        //The key is an auto - incrementing integer starting from 1.
        //  The value is the name
        Dictionary<int, string> nameDict = new Dictionary<int, string>();

        // Fill the dictionary with auto-incrementing keys
        int id = 1;
        foreach (string name in names)
        {
            nameDict[id] = name;
            id++;
        }

        // Display the dictionary contents
        foreach (KeyValuePair<int, string> entry in nameDict)
        {
            Console.WriteLine($"{entry.Key} => {entry.Value}");
        }
        //  Create a Hashtable where:
        //The key is the name.
        //The value is the length of the name.

        Hashtable nameLengths = new Hashtable();

        // Add names and their lengths to the hashtable
        foreach (string name in names)
        {
            nameLengths[name] = name.Length;
        }

        // Display the hashtable contents
        foreach (DictionaryEntry entry in nameLengths)
        {
            Console.WriteLine($"{entry.Key} => {entry.Value}");
        }









    }


}