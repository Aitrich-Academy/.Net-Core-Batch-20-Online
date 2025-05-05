using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_list
{
    internal class Program
    {
        static List<Employee> employees = new List<Employee>();

        static void Main(string[] args)
        {

            bool running = true;

            while (running)
            {
                Console.WriteLine("\nEmployee Management System");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Display All Employees");
                Console.WriteLine("3. Filter Employees by Department");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        DisplayAllEmployees();
                        break;
                    case "3":
                        FilterByDepartment();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }

            Console.WriteLine("Program ended.");
        }

        static void AddEmployee()
        {
            try
            {
                Console.Write("Enter Employee ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Enter Department: ");
                string department = Console.ReadLine();

                Employee employee = new Employee { Id = id, Name = name, Age = age, Department = department };
                employees.Add(employee);

                Console.WriteLine("Employee added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void DisplayAllEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees to display.");
                return;
            }

            Console.WriteLine("\nList of All Employees:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Age: {emp.Age}, Department: {emp.Department}");
            }
        }

        static void FilterByDepartment()
        {
            Console.Write("Enter Department to filter by: ");
            string department = Console.ReadLine();

            var filtered = employees.Where(e => e.Department.Equals(department, StringComparison.OrdinalIgnoreCase)).ToList();

            if (filtered.Count == 0)
            {
                Console.WriteLine("No employees found in this department.");
                return;
            }

            Console.WriteLine($"\nEmployees in Department '{department}':");
            foreach (var emp in filtered)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Age: {emp.Age}, Department: {emp.Department}");
            }
        }
    }
}
    

