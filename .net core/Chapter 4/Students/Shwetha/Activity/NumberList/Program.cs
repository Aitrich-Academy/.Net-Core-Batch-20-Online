using System;
using System.Collections.Generic;
using System.Linq;
namespace NumberList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);

            var lin = from item in list
                      where item >5 && item < 10
                      select item;


            foreach(var item in lin)
            {
                Console.WriteLine(item);
            }
            List<string> string_list = new List<string>();
            string_list.Add("Apple");
            string_list.Add("Orange");
            string_list.Add("Cat");
            string_list.Add("Dog");
            string_list.Add("Date");
            string_list.Add("Home");
            string_list.Add("lion");

            var elemt = from item in string_list
                        where item.Contains("e")
                        select item;

            var metho_elemt = string_list.Where(e => e.Contains("o")).Select(e => e);
            foreach(var i in metho_elemt)
            {
                Console.WriteLine(i);
            }

            //foreach(var i in elemt)
            //{
            //    Console.WriteLine(i);
            //}

        }
    }
}
