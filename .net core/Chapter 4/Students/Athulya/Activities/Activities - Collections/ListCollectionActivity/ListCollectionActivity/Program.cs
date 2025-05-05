using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace ListCollectionActivity
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee[] emp = new Employee[100];
            List<Employee> employeeList = new List<Employee>();

            string choice = "";
            while (choice != "4")
            {
                Console.WriteLine("Select options");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Display");
                Console.WriteLine("3.Filterd");
                Console.WriteLine("4.Exit");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        {
                            Console.WriteLine("please enter Employee details ");
                            Console.WriteLine("...................................");

                            Employee employee = new Employee();
                            Console.WriteLine("Enter your id :");
                            employee.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter your name :");
                            employee.Name = Console.ReadLine();
                            Console.WriteLine("Enter your Age :");
                            employee.Age = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter your Department :");
                            employee.Department = Console.ReadLine();

                            employeeList.Add(employee);

                        }
                        break;
                    case "2":
                        Console.WriteLine("Display the Employee detail list");
                        Console.WriteLine("...........................");

                        foreach (var item in employeeList)
                        {
                            Console.WriteLine("Id :{0}",item.Id);
                            Console.WriteLine("Name : {0}",item.Name);
                            Console.WriteLine("Age : {0}",item.Age);
                            Console.WriteLine("Department :{0}",item.Department);
                            Console.WriteLine("\n.............................");
                           
                        }
                        Console.WriteLine("\n");
                        break;
                    case "3":
                        Console.WriteLine("department name : ");
                        string x = Console.ReadLine();
                        foreach (var item in employeeList)
                        {
                            if(item.Department == x)
                            {
                                Console.WriteLine(item.Name + " - " + item.Department);
                            }
                        }

                        break;
                    case "4":
                        Console.WriteLine("Exit");
                        return;
                    default:
                        Console.WriteLine("invalid");
                        break;
                }
                Console.WriteLine("Do you want continue ? (y/n):");
                string y = Console.ReadLine();
            }

          
        }

    }

 }
    

