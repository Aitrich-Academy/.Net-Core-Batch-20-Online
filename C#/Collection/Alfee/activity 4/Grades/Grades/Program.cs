using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }

    public Student(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }
}

class Program
{
    static void Main()
    {
        // List of students
        List<Student> students = new List<Student>
        {
            new Student("Alice", 20, "A+"),
            new Student("Bob", 22, "B"),
            new Student("Charlie", 23, "A+"),
            new Student("David", 21, "C"),
            new Student("Eve", 19, "A+")
        };

        // LINQ query to find students with Grade "A+"
        var aPlusStudents = from student in students
                            where student.Grade == "A+"
                            select student.Name;

        // Display the results
        Console.WriteLine("Students with Grade A+:");
        foreach (var name in aPlusStudents)
        {
            Console.WriteLine(name);
        }
    }
}