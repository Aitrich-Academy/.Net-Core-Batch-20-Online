using System;
using System.Collections;
using System.Collections.Generic;
namespace Generic
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //List<string> list = new List<string>();
            //list.Add("a");
            //list.Add("b");
            //list.Add("c");
            //list.Add("d");

            //Console.WriteLine("capacity of the list : {0}",list.Capacity);
            //Console.WriteLine("count of the list : {0}",list.Count);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //list.Add("e");
            //Console.WriteLine("capacity of the list : {0}", list.Capacity);
            //Console.WriteLine("count of the list : {0}", list.Count);

            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //dic.Add(1, "a");
            //dic.Add(2, "b");
            //dic.Add(3, "c");
            //dic.Add(4, "d");
            //dic.Add(5, "e");

            //dic.Remove(2);
            
            //Console.WriteLine(dic.ContainsKey(7));
            //Console.WriteLine(dic.ContainsValue("swe"));

            //Console.WriteLine("Elemets are :");
            //foreach (KeyValuePair<int, string> item in dic)
            //{
            //    Console.WriteLine(item.Value);
            ////}
            ////Console.WriteLine(dic.Count);

            //SortedList<int, string> sl = new SortedList<int, string>();
            //sl.Add(45, "fgd");
            //sl.Add(12, "qwe");
            //sl.Add(89, "pop");
            //sl.Add(23, "der");
            //Console.WriteLine("Array elements ");
            //foreach(var item in  sl)
            //{
            //    Console.WriteLine(item.Value);
            //    Console.WriteLine(item.Key);
            //}
            //sl.Remove(12);
            //Console.WriteLine( sl.ContainsKey(12));
            //Console.WriteLine(sl.ContainsValue("bbbb"));

            //Queue<int> ints = new Queue<int>();
            //ints.Enqueue(1);
            //ints.Enqueue(2);
            //ints.Enqueue(3);
            //ints.Enqueue(4);
            //Console.WriteLine("elements are");
            //foreach (int i in ints)
            //{
            //    Console.WriteLine(i);
            //}
            //ints.Dequeue();
            //Console.WriteLine("elements are");
            //foreach (int i in ints)
            //{
            //    Console.WriteLine(i);
            //}

            Stack<string> strings = new Stack<string>();
            strings.Push("aaaaa");
            strings.Push("bbbbbbbbb");
            strings.Push("mmmmmmm");
            strings.Push("qqqqqqq");
            Console.WriteLine("elements are");
            foreach (string s in strings)
            {

            Console.WriteLine(s); 
            }
            Console.WriteLine( strings.Contains("ggg"));
            Console.WriteLine("The peekest elemt",strings.Peek);
            strings.Pop();
            Console.WriteLine("elements are");
            foreach (string s in strings)
            {

                Console.WriteLine(s);
            }



        }
    }
}

