using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGPAApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

             
            Student[] students = new Student[numberOfStudents];

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"\nEntering details for Student {i + 1}");

                var student = new Department();

                Console.Write("Enter Name: ");
                student.Name = Console.ReadLine();

                while (true)
                {
                    try
                    {
                        Console.Write("Enter Age (18-25): ");
                        student.Age = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Invalid Age. " + ex.Message);
                    }
                }

                Console.Write("Enter Department Name: ");
                student.DepartmentName = Console.ReadLine();

                student.Marks1 = ReadMarks("Marks 1");
                student.Marks2 = ReadMarks("Marks 2");
                student.Marks3 = ReadMarks("Marks 3");
                student.Marks4 = ReadMarks("Marks 4");
                student.Marks5 = ReadMarks("Marks 5");
                student.Marks6 = ReadMarks("Marks 6");
 

                students[i] = student;
            }

            
            Console.WriteLine("\nStudent Details:");
            foreach (var student in students)
            {
                student.CalculateCGPA();
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, CGPA: {student.CGPA:F2}, Grade: {student.Grade}");

            }

             
            var topper = Department.FindTopper(students);
            if (topper != null)
            {
                Console.WriteLine($"\nTopper: {topper.Name}, CGPA: {topper.CGPA:F2}, Grade: {topper.Grade}");
            }
            else
            {
                Console.WriteLine("\nNo students found.");
            }

            Console.ReadLine();
        }

        static double ReadMarks(string subjectName)
        {
            double marks;
            while (true)
            {
                try
                {
                    Console.Write($"Enter {subjectName} (0-100): ");
                    marks = double.Parse(Console.ReadLine());
                    if (marks < 0 || marks > 100)
                        throw new ArgumentOutOfRangeException("Marks must be between 0 and 100.");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid input. " + ex.Message);
                }
            }
            return marks;
        }
    }
}

    


    

