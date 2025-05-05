using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActivityLinq;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> list = new List<Student>()
        {
            new Student{Id = 1, Name = "Asha", Score = 98 },
             new Student{Id = 2, Name = "Arun", Score = 89 },
              new Student{Id = 3, Name = "Revathi", Score = 75 },
               new Student{Id = 4, Name = "Ashwin", Score = 91 }
        };
        var linqquery1 = from e in list
                         where e.Score > 80
                         select e;
        Console.WriteLine("Students who got marks above 80");
        foreach (var student in linqquery1)
        {
            Console.WriteLine(student.Name);
        }
        var topstudent = list.Where(x => x.Score > 80).Select(x => x.Name);
        Console.WriteLine("Students who got marks above 80");
        foreach (var student in topstudent)
        {
            Console.WriteLine(student);
        }



        List<int> numbers = new List<int> { 60, 30, 100, 56, 34, 23, 12, 59, 120, 20, 10, 4 };

        var linqquery = from x in numbers
                        where x > 50
                        select x;
        Console.WriteLine("Print numbers greater than 50 ");
        foreach (var n in linqquery)
            Console.WriteLine(n);
        Console.WriteLine();
        var methodsyntaxQuery = numbers.Where(x => x > 50).Select(x => x);
        Console.WriteLine("Print numbers greater than 50 ");
        foreach (var n in methodsyntaxQuery)
            Console.WriteLine(n);
        Console.WriteLine("**********************************************");



        List<string> names = new List<string>()
       { "ProMAx Tablet", "Gaming Tab", "Pro Machine", "Samsung Pro", "Apple i10", "Huwaei Tab"};

        var product = from x in names
                      where x.Contains("Pro")
                      select x;

        Console.WriteLine("List of Word with pro");
        foreach (var n in product)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine();
        var prod = names.Where(x => x.Contains("Pro")).Select(x => x);
        Console.WriteLine("List of Word with pro");
        foreach (var n in prod)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
        List<Employees> employees = new List<Employees>() {
          new Employees  { name = "Arun", year = 2024},
          new Employees  { name = "Sebastain", year = 1999},
          new Employees  { name = "Reena", year = 2021},
          new Employees  { name = "Abhishek", year = 2010}

    };

        var emp = from x in employees
                  where x.year > 2020
                  select x;

        Console.WriteLine("Employees who joined after 2020");
        foreach(var n in emp)
        {
            Console.WriteLine(n.name);
        }
        Console.WriteLine();
        var employ = employees.Where(x => x.year > 2020).Select(x => x.name);

        Console.WriteLine("Employees who joined after 2020");
        foreach (var n in employ)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
        List<object> list1 = new List<object> { 1, "HELLO", 3.25, "World", 90, "Rezia", 120, "Beauty" };

        var integer = list1.OfType<int>().ToList();

        foreach (var n in integer)
        {
            Console.WriteLine(n);
        }

    }
}