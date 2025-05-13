internal class Program
{
    class Employee
    {
        public string Name { get; set; }
        public string Designation { get; set; }
    }

    private static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee {Name = "Alfee", Designation = "Developer"},
            new Employee {Name = "Anzal", Designation = "Manager"},
            new Employee {Name = "Anood", Designation = "Manager"},
            new Employee {Name = "Ajmal", Designation = "System Head"},
            new Employee {Name = "Anupama", Designation = "Manager"},
            new Employee {Name = "Alfiya", Designation = "Manager"}
        };
        var managers = from e in employees where e.Designation =="Manager" select e;

        Console.WriteLine("List of Managers:");
        foreach(var manager in managers)
        {
            Console.WriteLine(manager.Name);
        }
    }
}