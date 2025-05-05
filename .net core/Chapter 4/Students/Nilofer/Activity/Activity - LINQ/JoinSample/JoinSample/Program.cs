 using System.Diagnostics;
using JoinSample;

internal class Program
{
    private static void Main(string[] args)
    {
        List <Student> students = new List<Student>
        {
    new Student { StudentId = 1, Name = "Alice" },
    new Student { StudentId = 2, Name = "Bob" },
    new Student { StudentId = 3, Name = "Charlie" }
        };

        List <Grade> grades = new List<Grade>
        {
    new Grade { StudentId = 1, grade = "A" },
    new Grade { StudentId = 2, grade = "B" }
        };



        var studentGrades = from st in students
                            join gr in grades
                            on st.StudentId equals gr.StudentId
                            select new { st.Name, gr.grade };
        
        foreach (var sg in studentGrades)
        {
            Console.WriteLine($"{sg.Name}: {sg.grade}");
        }

        var stdts = students.Join(
            grades,st => st.StudentId,   
            grade => grade.StudentId,        
            (st, grade) => new
            {
                st.Name,
                grade.grade
            });
        foreach (var sg in stdts)
        {
            Console.WriteLine($"{sg.Name}: {sg.grade}");
        }
    }

}