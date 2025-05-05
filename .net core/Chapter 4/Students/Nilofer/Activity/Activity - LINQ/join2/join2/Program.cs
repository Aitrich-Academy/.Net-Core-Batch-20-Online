using join2;

internal class Program
{
    private static void Main(string[] args)
    {
    var students = new List<Student>
    {
    new Student { StudentId = 1, Name = "Alice", Age = 20 },
    new Student { StudentId = 2, Name = "Bob", Age = 22 },
    new Student { StudentId = 3, Name = "Charlie", Age = 23 }
    };

     var enrollments = new List<Enrollment>
     {
    new Enrollment { StudentId = 1, CourseName = "Mathematics" },
    new Enrollment { StudentId = 1, CourseName = "Physics" },
    new Enrollment { StudentId = 2, CourseName = "Chemistry" }
    };

        var q = students.GroupJoin(
                enrollments,
                student => student.StudentId,       
                enrollment => enrollment.StudentId,  
                (student, studentEnrollments) => new
                {
                    StudentName = student.Name,
                    Courses = studentEnrollments.Select(e => e.CourseName).DefaultIfEmpty("None")
                }
            );

        foreach (var st in q)
        {
            Console.WriteLine($"{st.StudentName}");
            foreach (var course in st.Courses)
            {
                Console.WriteLine($"\t{course}");
            }
        }

    }
}