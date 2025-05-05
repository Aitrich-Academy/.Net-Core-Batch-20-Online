using JoinStudentEnrollment;

internal class Program
{
    private static void Main(string[] args)
    {
        IList<Student> students = new List<Student>()
        {
            new Student() {StudId = 1,Name =  "Alice",Age = 20 },
            new Student(){StudId = 2,Name = "Bob",Age =  22 },
            new Student(){StudId = 3,Name = "Charlie",Age =23 }
        };
        IList<Enrollment> enrollments = new List<Enrollment>
            {
            new Enrollment(){StudId = 1,CourseName = "Mathematics" },
            new Enrollment(){StudId = 1,CourseName = "Physics" },
            new Enrollment(){StudId = 2,CourseName = "Chemistry" }
        };

        var joinresult = from stud in students
                         join enroll in enrollments
                         on stud.StudId equals enroll.StudId into StudentGroup
                         select new
                         {
                             Students = stud,
                             EnrollmentStud = StudentGroup
                         };
        foreach (var joingrp in joinresult)
        {
            Console.WriteLine($"Student : {joingrp.Students.Name}, (Age : {joingrp.Students.Age})");
            Console.WriteLine("Couses Enrolled");
            if (joingrp.EnrollmentStud.Any())
            {
                foreach (var enrolstu in joingrp.EnrollmentStud)
                {
                    Console.WriteLine($" - {enrolstu.CourseName}");
                }


            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine(new string('-', 30)); 
        }
    }
        }
