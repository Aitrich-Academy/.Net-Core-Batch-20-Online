using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }

    public Employee(int id, string name, int age, string department)
    {
        Id = id;
        Name = name;
        Age = age;
        Department = department;
    }
}

class Program
{
    static List<Employee> employees = new List<Employee>();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Employee Management System");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Display All Employees");
            Console.WriteLine("3. Filter Employees by Department");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1") AddEmployee();
            else if (choice == "2") DisplayAllEmployees();
            else if (choice == "3") FilterEmployeesByDepartment();
            else if (choice == "4") return;
            else Console.WriteLine("Invalid choice.");
        }
    }

    // Add an employee to the list
    static void AddEmployee()
    {
        Console.Write("Enter Employee ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Employee Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter Employee Department: ");
        string department = Console.ReadLine();

        employees.Add(new Employee(id, name, age, department));
        Console.WriteLine("Employee added successfully.");
    }

    // Display all employees
    static void DisplayAllEmployees()
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("No employees to display.");
            return;
        }

        Console.WriteLine("\nList of Employees:");
        foreach (var employee in employees)
        {
            Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Age: {employee.Age}, Department: {employee.Department}");
        }
    }

    // Filter employees by department
    static void FilterEmployeesByDepartment()
    {
        Console.Write("Enter the department to filter by: ");
        string department = Console.ReadLine();

        var filteredEmployees = employees.Where(e => e.Department.Equals(department, StringComparison.OrdinalIgnoreCase)).ToList();

        if (filteredEmployees.Count == 0)
        {
            Console.WriteLine($"No employees found in the {department} department.");
            return;
        }

        Console.WriteLine($"\nEmployees in {department} department:");
        foreach (var employee in filteredEmployees)
        {
            Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Age: {employee.Age}");
        }
    }
}