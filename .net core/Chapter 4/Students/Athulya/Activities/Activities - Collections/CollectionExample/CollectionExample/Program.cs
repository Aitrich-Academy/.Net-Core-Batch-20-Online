using System.Collections;

namespace CollectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    ArrayList myList = new ArrayList();
            //    myList.Add("Name");
            //    myList.Add(2);
            //    myList.Add(9.50);
            //    myList.Add("x");
            //    myList.Add(10);
            //    myList.Add(myList.Count);
            //    foreach(var i in myList)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    myList.Remove(2);
            //    foreach(var i in myList)
            //    {
            //        Console.WriteLine(i);

            //    }
            //    myList.Insert(5, "Athu");
            //    foreach(var i in myList)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.WriteLine(myList.Count);

            //    myList.RemoveAt(3);
            //    foreach(var i in myList)
            //    {
            //        Console.WriteLine(i);

            //    }
            //    Console.WriteLine(myList.Count);

            //}

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(1, "Athulya");
            //hashtable.Add(2, "hinoy");
            //hashtable.Add(4, "Akash");
            //hashtable.Add("noren", 10);
            //foreach (DictionaryEntry x in hashtable)
            //{
            //    Console.WriteLine(x.Key + "Value" + x.Value);

            //}
            //Console.WriteLine("\n");
            //hashtable.Remove(4);
            //foreach(DictionaryEntry x in hashtable)
            //{
            //    Console.WriteLine(x.Key+"value" + x.Value);

            //}
            //Console.WriteLine("\n");
            //hashtable.ContainsKey("Athulya");
            //Console.WriteLine(hashtable.ContainsKey(1));
            //foreach (DictionaryEntry x in hashtable)
            //{
            //    Console.WriteLine(x.Key + "value" + x.Value);
            //}




            //Queue my = new Queue();
            //my.Enqueue("Athulya");
            //my.Enqueue("Hinoy");

            //my.Enqueue("kids");
            //Console.WriteLine(my.Peek());
            //Console.WriteLine(my.Count);
            //while (my.Count>0)
            //{

            //    Console.WriteLine(my.Dequeue());
            //}


            //Stack name = new Stack();
            //name.Push("Nolyn");
            //name.Push("noren");
            //name.Push("kids");
            //Console.WriteLine("the name is the stack :" + name.Contains("helo"));
            //Console.WriteLine("the name is deleted :" + name.Peek());
            //Console.WriteLine(name.Count);


            //Console.WriteLine("names in stack are :");

            //while (name.Count>0)
            //{

            //    Console.WriteLine(name.Pop());
            //}

            //Console.WriteLine(name.Count);

            SortedList jobs = new SortedList();
            jobs.Add("dotnet developer", 1);
            jobs.Add("Angular", 2);
            jobs.Add("fullstack", 3);
            Console.WriteLine("jobs available");
            foreach (var key in jobs.Keys)
            {
                Console.WriteLine(key + "Value" + jobs[key]);
            }
            jobs.Remove("Angular");
            foreach(var key in jobs.Keys)
            {
                Console.WriteLine(".........");
                Console.WriteLine(key + "value" + jobs[key]);
            }
            jobs.RemoveAt(1);
            jobs.IndexOfKey("fullstack");
            jobs.IndexOfValue(3);
           
            var cap=jobs.Capacity;
            Console.WriteLine(cap);
            
            var count = jobs.Count;
            Console.WriteLine(count);
            foreach (var key in jobs.Keys)
            {
                Console.WriteLine(key + "value" + jobs[key]);
            }
            jobs.Clear();

        }
    }
}


