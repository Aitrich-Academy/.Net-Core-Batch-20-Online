using System;
namespace LINQActivity
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            string choice, option;
            do
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Dispaly");
                Console.WriteLine("3. Above 60 grade");
                Console.WriteLine("4. Ascending Order");  
                Console.WriteLine("Enter your Choice......");
                option = Console.ReadLine();
                try
                {
                    switch (option)
                    {
                        case "1":
                            {
                                Add();
                                break;
                            }
                        case "2":
                            {
                                Show();
                                break;
                            }
                        case "3":
                            {
                                var grade = list.Where(e => e.Grade >= 60).OrderBy(e => e.Name);
                                Console.WriteLine("Filtered Students.....");
                                foreach (var student in grade)
                                {
                                    Console.WriteLine(student.Name);
                                    Console.WriteLine(student.Grade);
                                }
                                break;
                            }
                        case "4":
                            {
                                var group = list.GroupBy(e => e.Grade >= 60 ? "Passed" : "Failed");
                                Console.WriteLine("Grouped Student");
                                foreach (var student in group)
                                {
                                    Console.WriteLine(student.Key);
                                    Console.WriteLine("______________");    
                                    foreach(var s in student)
                                    {
                                        Console.WriteLine("Name : {0}",s.Name);
                                        Console.WriteLine("Grade : {0}", s.Grade);
                                    }
                                }
                            }
                                break;
                       default:
                            {
                                Console.WriteLine("Invalid Choice.!!!");
                                break;
                            }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("Do you wish to Continue {y /n} ....?");
                choice = Console.ReadLine();
            } while (choice == "Y" || choice == "y");
            void Add()
            {
                Student student = new Student();
                Console.WriteLine("Enter the ID of the Student :");
                student.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the name of the Student :");
                student.Name = Console.ReadLine();
                Console.WriteLine("Enter the Grade of the Student :");
                student.Grade = Convert.ToInt32(Console.ReadLine());
                list.Add(student);
            }
            void Show()
            {
                foreach (Student student in list)
                {
                    Console.WriteLine("ID : {0}",student.Id);
                    Console.WriteLine("Name : {0}",student.Name);
                    Console.WriteLine("Grade : {0}",student.Grade);
                    Console.WriteLine("*******************");
                }
            }
        }
    }
}