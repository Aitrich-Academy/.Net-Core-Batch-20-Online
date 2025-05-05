using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using EmployeeGroupBy;
internal class program
{
    public static List<Employee> employees = new List<Employee>();
    public static void Main(string[] args)
    {


        employees.Add(new Employee("Arun", "Accounts", 15000));
        employees.Add(new Employee("Atrira", "HR", 20000));
        employees.Add(new Employee("John", "HR", 10000));
        employees.Add(new Employee("Mary", "IT", 30000));
        employees.Add(new Employee("Ilana", "IT", 23000));
        employees.Add(new Employee("Alen", "Logistic", 32000));
        employees.Add(new Employee("Ahad", "Accounts", 23000));
        employees.Add(new Employee("serah", "Logistic", 31000));
        try
        {

            string choice = "";

            while (choice != "3")
            {
                Console.WriteLine("1 - Add an Employee");
                Console.WriteLine("2 - View Employees by Department");
                Console.WriteLine("3 - Exit");
                Console.WriteLine("Choose an option");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        DisplayEmployees();
                        break;
                    case "3":
                        Console.WriteLine("Exiting");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

        public static void AddEmployee()
        {

        try
        {

            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Department: ");
            string department = Console.ReadLine();
            Console.WriteLine("Enter Salary : ");
            int salary = Convert.ToInt32(Console.ReadLine());

            Employee employee = new Employee(name, department, salary);

            employees.Add(employee);

        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

        }

        public static void DisplayEmployees()
    {
        try
        {

            var q = employees.GroupBy(x => x.Department);

            Console.WriteLine($"Number of Departments : {q.Count()}");
            Console.WriteLine("------------------------------------");
            
            
            Console.WriteLine();
            foreach (var q2 in q)
            {
                Console.WriteLine($"Department Name : {q2.Key}");

                Console.WriteLine($"Number of Employees : {q2.Count()}");
                Console.WriteLine("--------------------------------------");

               
                int total = 0;
                float avg;

                foreach (var q3 in q2)
                {
                    Console.WriteLine($"Name : {q3.Name}  salary : {q3.Salary}");
                    total = total + q3.Salary;
                }

                avg = total / q2.Count();

                Console.WriteLine();

                Console.WriteLine($"Average salary of {q2.Key} : {avg}");
                Console.WriteLine();
            }

        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}