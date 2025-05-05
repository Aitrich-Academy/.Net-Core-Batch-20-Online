using System.Collections;
using System.ComponentModel;

public class Program
{
    public static void Main(string[] args)
    {
        ArrayList array = new ArrayList();
        array.Add(10);
        array.Add("hello");
        array.Add(5.5);
        array.Add("World");
        array.Add(20);
        

        //foreach(var item in array)
        //{
        //    Console.WriteLine(item);
        //}
        array.Add(30);
        array.Insert(2, "Inserted");
        array.RemoveAt(1);
        array.RemoveAt(3);
        Console.WriteLine(array.IndexOf(20));
        Console.WriteLine("Array");
        foreach (var item in array)
        {
            Console.Write(item+",");
        }
    }
}