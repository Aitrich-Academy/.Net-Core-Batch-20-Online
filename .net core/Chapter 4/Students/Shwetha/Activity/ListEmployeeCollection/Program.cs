using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
namespace ListEmployeeCollection
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string ch;
            List<Employee> list = new List<Employee>();
            void Add()
            { 
                Employee employee = new Employee();
                Console.WriteLine("Enter the Id");
                employee.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Name");
                employee.Name = Console.ReadLine();
                Console.WriteLine("Enter the Age");
                employee.Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Department");
                employee.Department = Console.ReadLine();
                
                list.Add(employee);
               
                Console.WriteLine("Employee details Stored");
            }
            void Show()
            {
                foreach(var item in list)
                {
                    Console.WriteLine("Id : {0}",item.Id);
                    Console.WriteLine("Name : {0}", item.Name);
                    Console.WriteLine("Age : {0}", item.Age);
                    Console.WriteLine("Department : {0}", item.Department);
                    Console.WriteLine("........................................");
                }
            }
            void Sort()
            {
                Console.WriteLine("Depertments are......");
                foreach (Employee item in list)
                {
                    Console.WriteLine(item.Department);
                }

                Console.WriteLine("Enter the choice");
                string choice = Console.ReadLine();
                foreach (Employee item in list)
                {
                    try
                    {
                        if (choice == item.Department)
                        {
                            Console.WriteLine("Employee List :");
                            Console.WriteLine(item.Name);
                        }
                        else
                        {
                            Console.WriteLine("No employees available in this department");
                        }
                    }
                  catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
            }

            do
            {
                Console.WriteLine("Choose option below");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Display Employee");
                Console.WriteLine("3. Sorted Display of Employee");
                Console.WriteLine("4.Exit");
                Console.WriteLine("seletct one.....");
                string str = Console.ReadLine();
                switch (str)
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
                            Sort();
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Exiting.............. ");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice ");
                            break;
                        }


                }
                Console.WriteLine("Do you want to continue (y/n)");
                ch = Console.ReadLine();
            } while (ch == "y" || ch == "Y");
           
        }
    }
}
