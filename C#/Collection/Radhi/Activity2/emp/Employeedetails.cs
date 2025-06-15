using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp
{
    public class Employeedetails
    {
        List<Employee> employees=new List<Employee>();
        Employee em = new Employee();
        public void Addingemp()
        {
            
            Console.WriteLine("enter the id of employee");
            int id=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("enter the name of employee");
            string name=Console.ReadLine();
            Console.WriteLine("enter the Age of employee");
           int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the department of employee");
            string department=Console.ReadLine();
            employees.Add(new Employee { Id = id, Name = name, Age = age,Department=department });
            Console.WriteLine("employee added successfully");

        }
        public void display()
        {

            foreach (Employee emp in employees)
            {
                Console.WriteLine($"Id:{emp.Id} \nName:{emp.Name} \nAge:{emp.Age} \nDepartment:{emp.Department}");

            }
        }

        public void Searchbydepartment()
        {


            Console.WriteLine("enter the department of employee");

            string dep=Console.ReadLine();

          
                if(employees.Count>0)
                {
                   foreach(Employee emp in employees)
                {
                    if(dep==emp.Department)
                    Console.WriteLine($"Name:{emp.Name} \n Department:{emp.Department}");
                    
                }

                }
                else
                {
                Console.WriteLine("employees are not avilable");

            }
            }
        }


    }

