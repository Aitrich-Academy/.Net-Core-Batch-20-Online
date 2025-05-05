using System.Security.Cryptography.X509Certificates;
using List__Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Employee> employee = new List<Employee>();
        string choice;
        do
        {
            Console.WriteLine("Employee System");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Display Employee");
            Console.WriteLine("3. Filter Employee by department");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Choose an option");

            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddEmployee(employee);
                    break;
                case "2":
                    DisplayEmployee(employee);
                    break;
                case "3":
                    FilterEmployee(employee);
                    break;
                case "4":
                    Console.WriteLine("Exiting the system.... GoodBye");
                    return;
                default:
                    Console.WriteLine("Invalid option , Please enter valid option");
                    break;
            }

        } while (choice != "4");
    }
        public static void AddEmployee(List<Employee> employee) {

        Console.WriteLine("Enter ID of employee");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the name of employee");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the age of employee");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the department of employee");
        string dept = Console.ReadLine();

        employee.Add(new Employee { Id = id, Name = name, Age = age, Department = dept });

        Console.WriteLine("Employee added successfully");
       
    }
    public static void DisplayEmployee(List<Employee> employee) {

        if (employee.Count == 0)
        {
            Console.WriteLine("Employee details empty");
            return;
        }
        Console.WriteLine("Employee Details are : ");

        foreach (var emp in employee)
        {
            Console.WriteLine(emp);
        }
    }
    public static void FilterEmployee(List<Employee> employee) { }


       
       }
    
