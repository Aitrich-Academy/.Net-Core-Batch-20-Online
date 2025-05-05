using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqGrade;
internal class Program
{
    private static void Main(string[] args)
    {
       IList<Student> students = new List<Student>()
        {
            new Student(1,"Asha",80),
            new Student(2,"Varun",90),
            new Student(3,"Abhishek",75),
            new Student(4,"Karthik",55),
            new Student(5,"Parvathi",60)
        };
        var groupresult = from student in students
                          where student.Grade >= 60
                          select student.Name;

        Console.WriteLine("Name of Students who have grade 60 or above");

        foreach (var stud in groupresult)
        {

            Console.WriteLine(stud);
        }
            var result = from st in groupresult
                         orderby st
                         select st;

            Console.WriteLine("Name of resulting students in Ascending order");
            foreach (var s in result)
            {
                Console.WriteLine(s);
            }
        var groupresults = from stud in students
                           group stud by stud.Grade >= 60 into grouped
                           select grouped;

        Console.WriteLine("Grouping Students as Pass or Fail");
        foreach(var student in groupresults)
        {
            string status = student.Key ? "Passed" : "Failed";
            Console.WriteLine($"\n {status}");

            foreach(var res in student)
            {
                Console.WriteLine(res);
            }
        }
        }
    }
