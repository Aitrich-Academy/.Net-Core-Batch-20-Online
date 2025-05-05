using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        list.Add("Apple");
        list.Add("Grapes");
        list.Add(5);
        list.Add(2);
        list.Add(3);

        foreach (var i in list)
        {
            Console.WriteLine(i);
        }

        list.RemoveAt(4);
        foreach (var i in list)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine(list.Count);

        list.Reverse();

        foreach (var i in list)
        {
            Console.WriteLine(i);
        }

        list.Add("sdsd");

        Console.WriteLine(list.Capacity);

        Hashtable ht = new Hashtable();

        ht.Add(1, "nilofer");
        ht.Add(2, 567);

        foreach(DictionaryEntry item in ht)
        {
            Console.WriteLine($"{item.Key} {item.Value}");
        }
        Console.WriteLine(ht.Count);

        ht.Remove(1);
        foreach (DictionaryEntry item in ht)
        {
            Console.WriteLine($"{item.Key} {item.Value}");
        }


        Console.WriteLine(ht.Contains("ab"));

        Queue queue = new Queue();

        queue.Enqueue("nilofer");
        queue.Enqueue("Ferah");
        queue.Enqueue("kenz");

        Console.WriteLine(queue.Peek());

        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
        
        Stack jobs = new Stack();

        jobs.Push("Dot net Developer");
        jobs.Push("Angular developer");
        jobs.Push("Python developer");

        Console.WriteLine(jobs.Peek());
        Console.WriteLine(jobs.Contains("accountant"));

        while(jobs.Count > 0)
        {
            Console.WriteLine(jobs.Pop());
        }

        SortedList sortedList = new SortedList();

        sortedList.Add("Java developer", 1);
        sortedList.Add("Angular ", 2);
        sortedList.Add("Python", 3);

        foreach(var item in sortedList.Keys)
        {
            Console.WriteLine($"{item}");
        }

        sortedList.Remove(1);

        Console.WriteLine(sortedList.Count);

        


    }
}