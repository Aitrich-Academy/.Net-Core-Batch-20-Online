using System.Collections;

namespace ArrayListCollection
{
    internal class Program
    {
      private  static void Main(string[] args)
        {
            ArrayList listarray = new ArrayList();
            listarray.Add("Athulya");
            listarray.Add("Hinoy");
            listarray.Add("nolyn");
            listarray.Add(15);
            listarray.Add(16);
            listarray.Add(28);
            listarray.Add(14);
            listarray.Add("noren");

            Console.WriteLine("The listed array are :");
            foreach(var x in listarray)
            {
                Console.WriteLine(x);

            }

            listarray.Reverse();
            foreach(var x in listarray)
            {
                Console.WriteLine(x);
            }
            listarray.Add("April 19");
            Console.WriteLine(listarray.Capacity);
            listarray.RemoveAt(5);
            foreach(var x in listarray)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine(listarray.Count);

            Console.WriteLine("-----------------");

            Hashtable hashT = new Hashtable();  
            hashT.Add(1,"Athulya Chacko");
            hashT.Add(2, 1992);
            hashT.Add(3, "may");
            hashT.Add(4, 15);
            foreach(DictionaryEntry i in hashT)
            {
                Console.WriteLine("{0} {1}", i.Key, i.Value);

            }
            Console.WriteLine(hashT.Count);

            hashT.Remove(2);
            foreach(DictionaryEntry i in hashT)
            {
                Console.WriteLine("{0} {1}", i.Key, i.Value);

            }

            Console.WriteLine(hashT.Count);
            Console.WriteLine(hashT.Contains("hinoy"));
            Console.WriteLine("----------------");


            Queue queue = new Queue();
            queue.Enqueue("Akash");
            queue.Enqueue("Chacko");
            queue.Enqueue("bency");
            Console.WriteLine(queue.Peek());

            while (queue.Count > 0) ;
            {
                Console.WriteLine(queue.Dequeue());

            }

            Console.WriteLine("----------------");

          Stack jobs = new Stack();

            jobs.Push(" Developer");
            jobs.Push("Tester");
            jobs.Push("Engineer");

            Console.WriteLine(jobs.Peek());
            Console.WriteLine(jobs.Contains("accountant"));

            while (jobs.Count > 0)
            {
                Console.WriteLine(jobs.Pop());
            }

            SortedList sortedList = new SortedList();

            sortedList.Add("Java developer", 1);
            sortedList.Add("Angular ", 2);
            sortedList.Add("Python", 3);

            foreach (var item in sortedList.Keys)
            {
                Console.WriteLine("{0}",item);
            }

            sortedList.Remove(1);

            Console.WriteLine(sortedList.Count);





        }
    }
}
