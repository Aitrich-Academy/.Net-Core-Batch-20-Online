using System;
using System.Collections.Generic;
namespace ListExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students_list = new List<Student>();
            string ch, option;
            do
            {
              
                try
                {
                    Console.WriteLine("1. Add");
                    Console.WriteLine("2. Find");
                    Console.WriteLine("Choice.....");
                    option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            {
                                Add();
                                break;
                            }
                        case "2":
                            {
                                find();
                                break;
                            }

                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Do you wish to continue");
                ch = Console.ReadLine();
            } while (ch == "y" || ch == "Y");
            void Add()
            {
                Student student = new Student();
                Console.WriteLine("ID ");
                student.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("name ");
                student.Name = Console.ReadLine();
                students_list.Add(student);
            }
            void find()
            {
                var linquer = from item in students_list
                              where item.Id == 2
                              select item;
                foreach(var i in linquer)
                {
                    Console.WriteLine(i.Name);
                }
                //foreach(var item in  students_list)
                //{
                //    if(item.Id == 2)
                //    {
                //        Console.WriteLine(item.Name);
                //    }
                //}
            }
           

        }
    }
}
