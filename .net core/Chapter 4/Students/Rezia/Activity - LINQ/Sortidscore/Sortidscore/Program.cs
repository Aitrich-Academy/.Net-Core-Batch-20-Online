using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sortidscore;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> students = new List<Student>() 
        {
            new Student{id = 1, name ="Asha", score = 98},
            new Student{id = 2, name ="Abishek", score = 97},
            new Student{id = 3, name ="Arunraj", score = 90},
            new Student{id = 4, name ="Shalini", score = 98},
            new Student{id = 5, name ="Sandhya", score = 92},
            new Student{id = 6, name ="Pradeep", score = 97},
        };

        var stud = students.OrderBy(x => x.score).ThenBy(x => x.id).ToList();
        Console.WriteLine("Display Lowest to highest score");
        foreach(var studentee in stud)
        {
            Console.WriteLine($"Id = {studentee.id}, Name = {studentee.name}, Score = {studentee.score}");
        }
        Console.WriteLine("==========================================================");
        var student = students.OrderByDescending(x => x.score).ThenByDescending(x => x.id).ToList();
        Console.WriteLine("Display  highest to lowest score");
        foreach (var s in student)
        {
            Console.WriteLine($"Id = {s.id}, Name = {s.name}, Score = {s.score}");
        }
    }
}