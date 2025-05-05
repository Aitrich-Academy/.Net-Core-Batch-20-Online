using System.Linq;
using System.Collections.Generic;
using System;
namespace LinQ_groupBy
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add( new Student(1, "abc" , "IT"));
            list.Add(new Student(2, "kkkkk", "IT"));
            list.Add(new Student(3 , "ghj" ,"CCS"));
            list.Add(new Student(4, "jjj", "CCS"));
            list.Add(new Student(5, "iii", "computer"));
            //query method
            Console.WriteLine("Query method");
            var query = from stu in list
                        group stu by stu.Department;
            foreach(var item in query)
            {
                Console.WriteLine("Total departmets : {0}" ,query.Count());
                Console.WriteLine("Department : {0}", item.Key);
                Console.WriteLine("No of Students : {0}", item.Count());
                foreach(var i in  item)
                {
                    Console.WriteLine("Id : {0}  Name : {1}", i.Id, i.Name);
                }

            }
            //lamda method
            Console.WriteLine("Lamda method");
            var h = list.GroupBy(e => e.Department).Select(e => e);
          
            foreach( var item in h)
            {
               
                Console.WriteLine("Departments : {0}",item.Key );
                Console.WriteLine("No of Students : {0}", item.Count());
                {
                    foreach( var item2 in item)
                    {
                        //Console.WriteLine("No of Students : {0}", item2.Count);
                        Console.WriteLine("Id : {0}  Name : {1}" , item2.Id , item2.Name);
                            
                    }
                }
            }
        }
    }
}
