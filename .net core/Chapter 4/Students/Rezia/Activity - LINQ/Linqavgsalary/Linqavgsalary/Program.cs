using Linqavgsalary;

IList<Employee> employees = new List<Employee>()
        {
            new Employee{Name = "Sharath", Department = "CSE", Salary = 45000},
            new Employee{Name = "Shwetha", Department = "ECE", Salary = 42000},
            new Employee{Name = "Sumesh", Department = "CSE", Salary = 55000},
            new Employee{Name = "Swapna", Department = "CSE", Salary = 45000},
            new Employee{Name = "Vipin", Department = "IT", Salary = 43000},
            new Employee{Name = "AshaRaj", Department = "ECE", Salary = 44000},
            new Employee{Name = "Babitha", Department = "CSE", Salary = 50000},

        };
Console.WriteLine("Total number of employees :- {0}", employees.Count);
Console.WriteLine();
var groupdept = from emp in employees
                group emp by emp.Department into deptGroup
                select new
                {
                    Department = deptGroup.Key,
                    TotalEmployees = deptGroup.Count(),
                    AverageSalary = deptGroup.Average(x => x.Salary),
                    NamesofEmployee = deptGroup.Select(e => e.Name).ToList(),
                    

                };


foreach (var employ in groupdept)
{
    Console.WriteLine("Name of department :- {0}", employ.Department);
    Console.WriteLine();
    Console.WriteLine("Number of employees  :- {0}", employ.TotalEmployees);
    Console.WriteLine("Name of Employees :- {0}", String.Join(",",employ.NamesofEmployee));
    Console.WriteLine("____________________________________");
    Console.WriteLine($"Average Salary of {employ.Department} department :- {employ.AverageSalary}");
    Console.WriteLine();



}
