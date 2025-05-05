internal class Program
{
    private static void Main(string[] args)
    {
       // List<int> list = new List<int>();
       // list.Add(1);
       // list.Add(2);
       // list.Add(3);
       // list.Add(4);
       // list.Remove(3);
       // list.Add(5);
       // list.Add(6);
       //  Console.WriteLine(list.Count);
       // Console.WriteLine(list.Capacity);

       // foreach (int i in list)
       // {
       //     Console.WriteLine(i);
       // }

       // Dictionary<int,string> dict = new Dictionary<int,string>();
       // dict.Add(1, "2");
       // dict.Add(2, "3");
       // dict.Add(3, "4");
       // dict.Add(4, "5");
       // dict.Add(5, "6");
       // dict.Remove(3);
       // Console.WriteLine(dict.ContainsKey(4));
       //Console.WriteLine( dict.ContainsValue("3"));
       // Console.WriteLine(dict.Count);
        

       // foreach (var  i in dict)
       // {
       //     Console.WriteLine(i.Key + " : " + i.Value );
       // }

        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Python");
        queue.Enqueue("Java");
        queue.Enqueue("C++");
        queue.Enqueue("Dart");
        Console.WriteLine(queue.Count());
        Console.WriteLine(queue.Peek());
       
        {
            Console.WriteLine(queue.Dequeue());
        }

        Stack<string> skills = new Stack<string>();
        skills.Push("Java");
        skills.Push("Dotnet");
        skills.Push("Angular");
        skills.Push("Python");

        Console.WriteLine(skills.Count);
        Console.WriteLine(skills.Peek());
        Console.WriteLine(skills.Pop());
    }
}