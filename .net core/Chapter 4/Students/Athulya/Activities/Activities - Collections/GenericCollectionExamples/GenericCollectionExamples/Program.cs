using System.Security.Cryptography;

namespace GenericCollectionExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> value = new List<int>();
            value.Add(1);
            value.Add(2);
            value.Add(3);
            value.Remove(3);
            value.Add(4);
            Console.WriteLine(value.Count);
            Console.WriteLine(value.Capacity);
            foreach (var item in value)
            {
                Console.WriteLine(item);
            }



            Dictionary<int, string> mydic = new Dictionary<int, string>();
            mydic.Add(1, "athu");
            mydic.Add(2, "ahh");
            mydic.Remove(1);
            mydic.ContainsKey(2);
            mydic.ContainsValue("ahh");

            foreach (KeyValuePair<int, string> entry in mydic)
            {
                Console.WriteLine(entry.Value);
            }
            mydic.Clear();
            Console.WriteLine(mydic.Count);


            SortedList<int, string> helo = new SortedList<int, string>();
            helo.Add(1,"helo");
            helo.Add(2, "hii");
            helo.Add(5,"haa");
            foreach(var item in helo)
            {
                Console.WriteLine(item.Value);
                Console.WriteLine(item.Key);
            }





            Queue<string> myq = new Queue<string>();
            myq.Enqueue("hllloo");
            myq.Enqueue("haa");
            myq.Dequeue();





            Stack<string> mys = new Stack<string>();
            mys.Push("hi");
            mys.Push("haa");
            mys.Push("ahh");
            mys.Push("hahah");
            Console.WriteLine("top value is : {0}",mys.Peek());
            Console.WriteLine(mys.Contains("hahah"));
            Console.WriteLine(mys.Pop());






        }
    }
}
