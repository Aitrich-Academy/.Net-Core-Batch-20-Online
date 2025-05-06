using static System.Formats.Asn1.AsnWriter;
using System.Diagnostics;
using grade;

internal class Program
{
    private static void Main(string[] args)
    {
        // Store a SortedList<int, Student> where Student is a class with Name, Age, and Grade.Write methods to:
        //Add students.
        //Display students with Grade > 80.

        StudentManager manager = new StudentManager();

        // Adding students
        manager.AddStudent(101, new Student("Alice", 20, 85));
        manager.AddStudent(102, new Student("Bob", 21, 78));
        manager.AddStudent(103, new Student("Charlie", 22, 90));

        // Displaying students with grade > 80
        manager.DisplayHighGradeStudents();



    }
}