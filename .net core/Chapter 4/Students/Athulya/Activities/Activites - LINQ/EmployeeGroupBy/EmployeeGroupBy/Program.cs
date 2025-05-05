using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using EmployeeGroupBy;
internal class program
{
    public static List<Employee> employees = new List<Employee>();
    public static void Main(string[] args)
    {


        employees.Add(new Employee("Akash", "Engineer", 25000));
        employees.Add(new Employee("Alok", "Developer", 12000));
        employees.Add(new Employee("Athul", "Tester", 10000));
        employees.Add(new Employee("Deli", "IT", 30000));
        employees.Add(new Employee("Honey", "IT", 23000));
        employees.Add(new Employee("Anila", "Logistic", 32000));
        employees.Add(new Employee("Athulya", "Engineer", 23000));
        employees.Add(new Employee("Annet", "Logistic", 31000));
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

            Console.WriteLine("Number of Departments :{0}", q.Count());
            Console.WriteLine("------------------------------------");
            
            
            Console.WriteLine();
            foreach (var q2 in q)
            {
                Console.WriteLine("Department Name : {0}",q2.Key);

                Console.WriteLine("Number of Employees : { 0}",q2.Count());
                Console.WriteLine("--------------------------------------");

               
                int total = 0;
                float avg;

                foreach (var q3 in q2)
                {
                    Console.WriteLine("Name : {0}    salary : {1}  ",  q3.Name, q3.Salary);
                    total = total + q3.Salary;
                }

                avg = total / q2.Count();

                Console.WriteLine();

                Console.WriteLine("Average salary of {0} :{1}", q2.Key, avg);
                Console.WriteLine();
            }

        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}