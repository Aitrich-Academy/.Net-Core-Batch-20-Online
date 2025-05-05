
using GroupBy;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        IList<Student> students = new List<Student>()
        {
            new Student{StudentId = 1, StudentName = "Asha", StudentAge = 18},
            new Student{StudentId = 2,StudentName = "Aravind",  StudentAge=20},
            new Student{StudentId = 3,StudentName = "Govind", StudentAge = 18 },
            new Student{StudentId = 4,StudentName = "Malavika", StudentAge = 20},
            new Student{StudentId = 5, StudentName = "Sreekanth", StudentAge = 21},
        };
        var groupresult = from stud in students
                          group stud by stud.StudentAge;

        foreach (var agegroup in groupresult)
        {
            Console.WriteLine("Age Group {0} :", agegroup.Key);
            Console.WriteLine("+++++++++++++++++++++++++++++++++");
            foreach (Student st in agegroup)

            {
                Console.WriteLine("Student Id :{0} ", st.StudentId);
                Console.WriteLine("Student Name : {0} ", st.StudentName);
            }
        }
    }
}