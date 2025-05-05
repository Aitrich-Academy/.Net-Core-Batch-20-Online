using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using listemployee;

public class Program
{
    public static List<Employee> employees = new List<Employee>();
    public static int count = 0;
    public static void Main(string[] args)
    {
        bool program = false;
        while (!program)
        {
            Console.WriteLine("\nWELCOME TO EMPLOYEE MANAGEMENT\n");
            Console.WriteLine("1. Add employee");
            Console.WriteLine("2.Display employee");
            Console.WriteLine("3.filter employee");
            Console.WriteLine("4.Exit");

            Console.WriteLine("\nEnter option");
            string option = Console.ReadLine();
            
            switch (option)
            {
                case "1":
                    Add();
                    break;

                case "2":
                    displayemployee();
                    break;

                case "3":
                    filter();
                    break;

                case "4":
                    Console.WriteLine("Exiting");
                    return;
    
                default:
                    Console.WriteLine("invalid choice!!!");
                    break;

            }
        }
     }

    public static void Add()
    {
        try
        {
            Console.WriteLine("Enter employee id: ");
            string id = Console.ReadLine();
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter department: ");
            string department = Console.ReadLine();


            employees.Add(new Employee(id, name, age, department));
            count++;
            Console.WriteLine("employee added successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void displayemployee()

    {
        if (count == 0)
        {
            Console.WriteLine("No employee to display!!!");
            return;
        }
        else
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nEmployee{i + 1}");
                employees[i].display();
            }
        }
    }

    public static void filter()
    {
        Console.WriteLine("Enter an department to fitler");
        string filterdepartment= Console.ReadLine().ToLower();
        bool found= false;
      
        foreach (var dpt in employees)
        {
            
            for (int i = 0; i < count; i++)
            {
           
                if (filterdepartment == dpt.department)
                {
                    found= true;
                    dpt.filterdpt();
                }
                
                break;
             
                
                
            }
        }
        if (!found)
        {
            Console.WriteLine($"{filterdepartment} not found!!");
            
        }


    }
}