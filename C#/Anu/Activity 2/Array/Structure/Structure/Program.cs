
using System;

struct Student
{
    public int Id;
    public string Name;
    public float Marks;

    public Student(int id, string name, float marks)
    {
        Id = id;
        Name = name;
        Marks = marks;
    }

    public void Display()
    {
        Console.WriteLine("Student Details:");
        Console.WriteLine($"ID    : {Id}");
        Console.WriteLine($"Name  : {Name}");
        Console.WriteLine($"Marks : {Marks}");
    }
}




internal class Program
{
    private static void Main(string[] args)
    {
        // Create a student instance
        Student student = new Student(1, "Alice", 87.5f);

        // Display student details
        student.Display();

        // Wait for user input before closing (optional)
        Console.ReadLine();
    }
}