using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("1. Add() method");
        SortedList sl = new SortedList();
        sl.Add(3, "Three");
        sl.Add(1, "One");
        sl.Add(2, "Two");

        foreach(DictionaryEntry entry in sl)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}