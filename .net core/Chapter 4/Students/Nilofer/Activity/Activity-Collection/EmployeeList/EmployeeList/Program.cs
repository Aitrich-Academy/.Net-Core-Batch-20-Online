using EmployeeList;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
internal class Program
{
    public static List<Employee> employees = new List<Employee>();
    public static void Main(string[] args)
    {

       
        string input;
        string choice = "";

        employees.Add(new Employee(1, "Anu", 32, "IT"));
        employees.Add(new Employee(2, "Ferah", 21, "Accounts"));
        employees.Add(new Employee(3, "Serah", 25, "Sales"));
        employees.Add(new Employee(4, "Inaya", 30, "Sales"));
       
        while(choice != "4")
        {
            Console.WriteLine("Choose an option : ");
            Console.WriteLine("1 - Add new Employee ");
            Console.WriteLine("2 - Display Employee list ");
            Console.WriteLine("3 - Filter Employees ");
            Console.WriteLine("4 - Exit ");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddEmployee();
                    break;
                case "2":
                    DisplayEmployee();
                    break;
                case "3":
                    Filter();
                    break;
                case "4":
                    Console.WriteLine("Exiting ");
                    break;
            }
            //Console.WriteLine("Do you want to continue (y/n)");
            //input = Console.ReadLine().ToLower();
        } 
        

    }

       public static void AddEmployee()
       {
        Console.WriteLine("Enter Id : ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Age : ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Department : ");
        string department = Console.ReadLine();

        employees.Add(new Employee(id, name, age, department));

        Console.WriteLine("Employee Added successfully");

    }

        public static void DisplayEmployee()
        {



        foreach (Employee employee in employees)
        {
            Console.WriteLine($"Name : {employee.Name}");
            Console.WriteLine($"Id : {employee.Id}");
            Console.WriteLine($"Age : {employee.Age}");
            Console.WriteLine($"Department : {employee.Department}");
            Console.WriteLine();
        }

    }

    public static void Filter() { 

        Console.WriteLine("Enter Department to filter : ");
        string dept = Console.ReadLine().ToLower();

        Console.WriteLine($"Employees in {dept} department are : ");

        

        foreach (Employee emp in employees)
        {
            if(emp.Department.ToLower() == dept)
            {
                Console.WriteLine(emp.Name);
            }
        }
    }
}