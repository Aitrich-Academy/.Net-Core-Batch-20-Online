using Join;

internal class Program
{
    private static void Main(string[] args)
    {
        IList<Employee> employees = new List<Employee>()
        {
            new Employee() { EmployeeId = 1, Name = "Aakash", Age = 27 },
            new Employee() { EmployeeId = 2, Name = "Prakash", Age = 29 },
            new Employee() { EmployeeId = 3, Name = "Babitha", Age = 26 },
            new Employee() { EmployeeId = 4, Name = "Swapna", Age = 30 },
            new Employee() { EmployeeId = 5, Name = "Roshan", Age = 33 },
            new Employee() { EmployeeId = 6, Name = "Asha", Age = 37 }
        };
        IList<EmployeePost> posts = new List<EmployeePost>()
        {
            new EmployeePost() { EmployeeId = 1, EmpPost = "Python" },
            new EmployeePost() { EmployeeId = 2, EmpPost = "VB.NET" },
            new EmployeePost() { EmployeeId = 2, EmpPost = "Java" },
            new EmployeePost() { EmployeeId = 4, EmpPost = "C++" },
            new EmployeePost() { EmployeeId = 5, EmpPost = "Fortan" },
            new EmployeePost() { EmployeeId = 5, EmpPost = "C" },
            new EmployeePost() { EmployeeId = 6, EmpPost = "Javascript" }

        };

        var groupresult = from emp in employees
                          join skill in posts
                          on emp.EmployeeId equals skill.EmployeeId into Employeegroup
                          select new
                          {
                              Employees = emp,
                              Employeeskill = Employeegroup
                          };
        foreach (var employ in groupresult)
        {
            Console.WriteLine($"Employee Name : {employ.Employees.Name} (Age : {employ.Employees.Age}");
            Console.WriteLine("Skills Known");
            if (employ.Employeeskill.Any())
            {
                foreach (var emp in employ.Employeeskill)
                {
                    Console.WriteLine($"- {emp.EmpPost}");
                }

            }
            else
            {
                Console.WriteLine("Not Known any skill");
            }
            Console.WriteLine(new string('=', 30));
        }
    }
}