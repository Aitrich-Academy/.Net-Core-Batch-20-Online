using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Grade { get; set; }

    // Constructor for the Student class
    public Student(string name, int age, double grade)
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
        // Create a SortedList to store student records by roll number
        SortedList<int, Student> studentRecords = new SortedList<int, Student>();

        // Add students
        AddStudent(studentRecords, 101, "Alice", 20, 85.5);
        AddStudent(studentRecords, 102, "Bob", 22, 75.0);
        AddStudent(studentRecords, 103, "Charlie", 21, 92.3);
        AddStudent(studentRecords, 104, "David", 23, 88.0);

        // Display students with Grade > 80
        Console.WriteLine("Students with Grade > 80:");
        DisplayStudentsWithGradeAbove80(studentRecords);
    }

    // Method to add a student to the SortedList
    static void AddStudent(SortedList<int, Student> records, int rollNumber, string name, int age, double grade)
    {
        Student student = new Student(name, age, grade);
        records.Add(rollNumber, student);
    }

    // Method to display students with Grade > 80
    static void DisplayStudentsWithGradeAbove80(SortedList<int, Student> records)
    {
        foreach (var record in records)
        {
            if (record.Value.Grade > 80)
            {
                Console.WriteLine($"Roll Number: {record.Key}, Name: {record.Value.Name}, Age: {record.Value.Age}, Grade: {record.Value.Grade}");
            }
        }
    }
}