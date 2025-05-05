using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "Alice", Age = 20, Grade = "A+" },
                new Student { Name = "Bob", Age = 22, Grade = "B" },
                new Student { Name = "Charlie", Age = 21, Grade = "A+" },
                new Student { Name = "David", Age = 23, Grade = "C" }
            };

            // LINQ query to find students with Grade "A+"
            var topStudents = from student in students
                              where student.Grade == "A+"
                              select student.Name;

            // Display the results
            Console.WriteLine("Students with Grade A+:");
            foreach (var name in topStudents)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine(); // Keep console open
        }
    }
}
    

