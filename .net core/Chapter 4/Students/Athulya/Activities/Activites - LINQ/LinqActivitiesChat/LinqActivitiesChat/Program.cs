namespace LinqActivitiesChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> pro = new List<string>()
            {
                "oppo pro",
                    "pro 6vivo",
                    "Hp Laptop",
                    "Lenovo",
                    "I hone 16 pro max"
            };
            var product = from i in pro
                          where i.Contains("pro")
                          select i;
            foreach (var item in product)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var prod = pro.Where(i => i.Contains("pro")).Select(i => i);
            foreach(var x in prod)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("--------------------------------");

            List<Employee> employees = new List<Employee>()
        {
            new Employee("Athulya", 2021),
            new Employee("Akash",2011),
            new Employee("Hinoy",2002),
            new Employee("Chacko", 2023)
        };

            Console.WriteLine("Employee List");
            foreach (var employee in employees)
            {
                Console.WriteLine("Name :{0}   Year of Joining :{1} ",employee.Name, employee.YearOfJoining);
            }
            Console.WriteLine();

            var emp = from i in employees
                      where i.YearOfJoining > 2020
                      select i;

            foreach (var employee in emp)
            {
                Console.WriteLine(employee.Name);
            }

            var em = employees.Where(e => e.YearOfJoining > 2020).Select(e => e.Name);
            foreach (var employee in em)
            {
                Console.WriteLine(employee);
            }

        }
    }
        }
   