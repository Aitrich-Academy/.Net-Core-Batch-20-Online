using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Records
{
    internal class Program
    { 
        struct Employee
        {
            public int EmployeeID;
            public string Name;
            public double Salary;
        }
        static void Main(string[] args)
        {
            const int size = 5;
            Employee[] employees = new Employee[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"\n Enter details for Employee {i + 1} :");
                Console.Write("Employee ID :");
                employees[i].EmployeeID= int.Parse( Console.ReadLine() ); 
                Console.Write("Name :");
                employees[i].Name= Console.ReadLine();
                Console.Write("Salary :");
                employees[i].Salary= double.Parse( Console.ReadLine() );
            }

            Console.WriteLine("\n Employee Details :");
            foreach (var emp in employees) { 
            Console.WriteLine($"ID : {emp.EmployeeID} , Name : {emp.Name} , Salary : { emp.Salary}");
            }

            double highest=employees[0].Salary;
            double lowest = employees[0].Salary;
            foreach (var emp in employees)
            {
                if (emp.Salary > highest)
                {
                    highest = emp.Salary;
                }
                if (emp.Salary < lowest)
                {
                    lowest = emp.Salary;
                }
            }

            Console.WriteLine($"\n Highest Salary : {highest}");
            Console.WriteLine($"\n Lowest Salary : {lowest}");

        }
    }
}
