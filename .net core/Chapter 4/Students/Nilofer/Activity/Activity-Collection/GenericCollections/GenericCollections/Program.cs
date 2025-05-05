internal class Program
{
    private static void Main(string[] args)
    {
        List<string> list = new List<string>();
        list.Add("kenz");
        list.Add("luham");
        list.Add("ferah");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(list.Count);
        Console.WriteLine(list.Capacity);
        list.Add("nilofer");
        Console.WriteLine(list.Capacity);

        Console.WriteLine();

        Dictionary<string,int> dict = new Dictionary<string,int>();

        dict.Add("a", 23);
        dict.Add("b", 123);
        dict.Add("c", 456);

        

        foreach (var item in dict)
        {
            Console.WriteLine(item);
        }

        foreach(KeyValuePair<string,int> pair in dict)
        {
            Console.WriteLine($"{pair.Key} - {pair.Value}");
        }

        SortedList<string, int> mylist = new SortedList<string, int>();

        mylist.Add("s", 23);
        mylist.Add("h", 123);
        mylist.Add("y", 456);

        foreach (var item in mylist)
        {
            Console.Write(item.Key);
            Console.WriteLine(item.Value);
        }

        Queue<string> queue = new Queue<string>();

        queue.Enqueue("s");
        queue.Enqueue("h");
        queue.Enqueue("y");

        while (queue.Count >0)
        {
            Console.WriteLine(queue.Dequeue());
        }





    }



}