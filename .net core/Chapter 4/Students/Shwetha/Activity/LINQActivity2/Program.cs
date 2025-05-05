using System;
namespace LINQActivity2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Age = 20 },
            new Student { Id = 2, Name = "Bob", Age = 22 },
            new Student { Id = 3, Name = "Charlie", Age = 23 }
        };

            var enrollments = new List<Enrollments>
        {
            new Enrollments { Id = 1, Course = "Mathematics" },
            new Enrollments { Id = 1, Course = "Physics" },
            new Enrollments { Id = 2, Course = "Chemistry" }
        };
            var query = from student in students
                        join enrollment in enrollments
                        on student.Id equals enrollment.Id into studentEnrollments
                        from enrollment in studentEnrollments.DefaultIfEmpty()
                        select new
                        {
                            StudentName = student.Name,
                            CourseName = enrollment?.Course ?? "None"
                        };
            Console.WriteLine("Student Enrollments:");
            foreach (var result in query)
            {
                Console.WriteLine($"Name: {result.StudentName}, Course: {result.CourseName}");
            }

        }
    }
}
