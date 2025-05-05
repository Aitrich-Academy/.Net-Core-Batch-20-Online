using ListofEmployeeLINQ;

namespace ListofEmployeeLINQ
{
    internal class Program
    {
        List<Employee> employees = new List<Employee>();
        static void Main(string[] args)
        {
            
            //employees.Add(new Employee("Akash", "tester", 150000));
            //employees.Add(new Employee("Athul", "developer", 250000));
            //employees.Add(new Employee("Alok", "tester", 100000));
            //employees.Add(new Employee("Anwin", "tester", 250000));
            //employees.Add(new Employee("Antony", "developer", 120000));
            //employees.Add(new Employee("Annliya", "tester", 10000));
            //employees.Add(new Employee("Angelin", "engineer", 130000));

           

            }
            string choose = "";
            string ch;
            do
            {
                Console.WriteLine("Choose");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Display");
                Console.WriteLine("3.Exit");
                choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Display();
                        break
                            case "3":
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("invalid");
                        break;
                }
                Console.WriteLine("do you want continue ? y/n");

                ch = Console.ReadLine();

            } while (ch == "Y"&& ch== "y");
        }

 public void Add()
        {
            employees.Add(new Employee("Akash", "tester", 150000));
            employees.Add(new Employee("Athul", "developer", 250000));
            employees.Add(new Employee("Alok", "tester", 100000));
            employees.Add(new Employee("Anwin", "tester", 250000));
            employees.Add(new Employee("Antony", "developer", 120000));
            employees.Add(new Employee("Annliya", "tester", 10000));
            employees.Add(new Employee("Angelin", "engineer", 130000));

        }

        public void Display()
        {
    var emp = employees.GroupBy(e => e.department).Select(e => e);

    foreach (var emp1 in emp)
    {
        Console.WriteLine("department names  :  " + emp1.Key);
        Console.WriteLine("no of departments  :   " + emp1.Count());

        int avg = 0;
        int x = 0;

        foreach (var emp2 in emp1)
        {
            Console.WriteLine("Name  :   " + emp2.name);
            Console.WriteLine("Salary :   " + emp2.salary);
            Console.WriteLine("Department:  " + emp2.department);

            x = x + emp2.salary;

        }

        avg = x / emp1.Count();
        Console.WriteLine("average of {0} department    :{1}", emp1.Key, avg);

    }

}
}
