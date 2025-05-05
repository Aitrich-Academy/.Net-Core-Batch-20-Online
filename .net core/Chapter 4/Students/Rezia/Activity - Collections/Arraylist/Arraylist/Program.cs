using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
       ArrayList arrayList = new ArrayList();
        arrayList.Add(10);
        arrayList.Add("Hello");
        arrayList.Add(5.5);
        arrayList.Add("World");
        arrayList.Add(20);

        Console.WriteLine("List of array as follows");
        foreach(var item in arrayList)
        {
            Console.WriteLine(item);
        }
        arrayList.Add(30);
        foreach(var item in arrayList)
        {
            Console.WriteLine(item);
        }
        arrayList.Insert(2, "inserted");

        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
        arrayList.Remove("Hello");
        foreach (var item in arrayList)
        {  Console.WriteLine(item); }
        arrayList.RemoveAt(3);
        foreach (var item in arrayList)
        { Console.WriteLine(item); }
        Console.WriteLine(arrayList.IndexOf(20));
        foreach (var item in arrayList)
        { Console.WriteLine(item); }

    }
}   