using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
namespace EmployeeList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
           
            string ch, option;
            //list.Add(new Employee("jan" , "Production" , 50000));
            //list.Add(new Employee("feb", "Sales", 30000));
            //list.Add(new Employee("mar", "Production", 55000));
            //list.Add(new Employee("apr", "sales", 39000));
            //list.Add(new Employee("may", "Manufacture", 50000));
            //list.Add(new Employee("jun", "Production", 58000));
            //list.Add(new Employee("jul", "Manufacture", 45000));



        

            do
            {
                Console.WriteLine("Employee Data");
                Console.WriteLine("1. Add employee");
                Console.WriteLine("2. Display ");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Choose any option");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        {
                            Employee employee = new Employee();
                            Console.WriteLine("Name");
                            employee.Name = Console.ReadLine();
                            Console.WriteLine("Departmet");
                            employee.Departments = Console.ReadLine();
                            Console.WriteLine("Salary");
                            employee.Salary = Convert.ToInt32(Console.ReadLine());
                            list.Add(employee);
                            Console.WriteLine("Added succesfully");
                            break;
                        }
                    case "2":
                        {
                            var emp = list.GroupBy(e => e.Departments).Select(e => e);

                            Console.WriteLine("Total departmets : {0}", emp.Count());
                            foreach (var item in emp)
                            {
                                Console.WriteLine("Department : {0}", item.Key);
                                Console.WriteLine("No of Employees : {0}", item.Count());
                                int avg;
                                int result = 0;
                                foreach (var i in item)
                                {
                                    Console.WriteLine(i.Name);
                                    Console.WriteLine(i.Departments);
                                    result = result + i.Salary;

                                }
                                avg = result / item.Count();
                                Console.WriteLine("Average Salary : {0}", avg);
                            }
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Exiting......");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice");
                            break;
                        }
                }
                Console.WriteLine("Do you wish to continue");
                ch = Console.ReadLine();
            } while (ch == "y" || ch == "Y");
        }
    }
}
