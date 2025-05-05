using Employeesgroupby;

public class Program
{
    public static List<Employee> employees = new List<Employee>();
    public static int count=0;
    
   
    public static void Main(string[] args)
    {
        //employees.Add(new Employee("manu", "IT", 2000));
        //employees.Add(new Employee("anu", "CSE", 3000));
        //employees.Add(new Employee("vinu", "CSE", 1000));
        //employees.Add(new Employee("loki", "IT", 3000));
        bool pgrm = false;
        while (!pgrm)
        {
            Console.WriteLine("1.Add Employee");
            Console.WriteLine("2.Display employee by department");
            Console.WriteLine("3.Average salaray of workers");
            Console.WriteLine("4.Exit");
            Console.WriteLine("Enter your choice:");
            string choice=Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Add();
                    break;

                case "2":
                    var query = employees.GroupBy(e => e.department);

                    Console.WriteLine($"Total employees in company: {employees.Count()}");

                    foreach (var q1 in query)
                    {
                        Console.WriteLine($"Departmet: {q1.Key}");
                        foreach (var q2 in q1)
                        {
                            Console.WriteLine($"Name:{q2.name} , salary:{q2.salary}");
                        }
                    }
                    break;

                 case "3":
                    average();
                    break;

                case "4":
                    Console.WriteLine("Exiting....");
                    return;


            }

        }


        //var query = employees.GroupBy(e => e.department);

        //Console.WriteLine($"Total employees in company: {employees.Count()}");

        //foreach (var q1 in query)
        //{
        //    Console.WriteLine($"Departmet: {q1.Key}");
        //    foreach (var q2 in q1) 
        //    {
        //        Console.WriteLine($"Name:{q2.name} , salary:{q2.salary}");
        //    }
        //}

        //average();
    }

    public static void average()
    {
        if (count == 0)
        {
            Console.WriteLine("no workers!!!");
            return;
        }
        int avg = 0;
        foreach (var e in employees) 
        {
            avg += e.salary / count;
        }
        Console.WriteLine($"\nAverage salary of workers: {avg}");

    }

    public static void Add()
    {
        Console.WriteLine("Enter name: ");
        string name=Console.ReadLine();
        Console.WriteLine("Enter Department: ");
        string department=Console.ReadLine().ToLower();
        Console.WriteLine("Enter salary: ");
        int salary=Convert.ToInt32(Console.ReadLine());
        employees.Add(new Employee(name, department, salary));
        count++;
        Console.WriteLine("Successfully added");
    }
}