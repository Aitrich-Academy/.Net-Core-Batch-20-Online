using Linq2;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int>()
        {
            34,78,54,67,23,12,34,98,15
        };

        var linq = from i in numbers
                   where i > 50
                   select i;

        foreach(int i in linq)
        {
            Console.WriteLine(i);
            
        }

        Console.WriteLine();

        var num = numbers.Where(i => i > 50).Select(i => i);

        foreach (int i in num)
        {
            Console.WriteLine(i);

        }

        List<Student> students = new List<Student>
        {
            new Student("Kenza", 78),
            new Student("Ferah" , 88),
            new Student("Serah", 87),
            new Student("Inaya", 90),
            new Student("Advik", 82)

        };

        Console.WriteLine("Students List");
        foreach(Student s  in students)
        {
            Console.WriteLine($"Name : {s.Name}  Score : {s.Score}");
        }

        var st = from i in students
                 where i.Score > 80
                 select i;

        Console.WriteLine("Students scored above 80 are:");
        
        foreach (Student student in st)
        {
            Console.WriteLine(student.Name);
        }

        Console.WriteLine();

        var stu=students.Where(i=> i.Score > 80).Select(i=>i.Name);

        foreach(var student in stu)
        {
            Console.WriteLine(student);
        }

        List<string> products = new List<string>()
        {
            "I phone 16 Pro",
            "I phone 14 Pro Max",
            "Mac Book",
            "Hp Laptop",
            "One plus Nord 3 Pro"

        };

        var prod = from i in products
                   where i.Contains("Pro")
                   select i;
        foreach(var product in prod)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine();

        var pr = products.Where(i => i.Contains("Pro")).Select(i => i);

        foreach(var product in pr)
        {
            Console.WriteLine(product);
        }

        List<Employee> employees = new List<Employee>()
        {
            new Employee("Liyam", 2023),
            new Employee("Ali",2014),
            new Employee("Serah",2021),
            new Employee("Anila", 2024)
        };

        Console.WriteLine("Employee List");
         foreach(var employee in employees)
        {
            Console.WriteLine($"Name : {employee.Name}  Year of Joining : {employee.YearOfJoining}");
        }
         Console.WriteLine();

        var emp= from i in employees
                 where i.YearOfJoining > 2020
                 select i;

        foreach(var employee in emp)
        {
            Console.WriteLine(employee.Name);
        }

        var em = employees.Where(e=>e.YearOfJoining > 2020).Select(e => e.Name);
         foreach(var employee in em)
        {
            Console.WriteLine(employee);
        }

    }
}