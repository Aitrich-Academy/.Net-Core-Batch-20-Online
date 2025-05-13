using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGPAApp
{
     public class Department : Student
    {
        public string DepartmentName { get; set; }

        public static Student FindTopper(Student[] students)
        {
            foreach (var student in students)
            {
                student.CalculateCGPA();
            }

            return students.OrderByDescending(s => s.CGPA).FirstOrDefault();
        }
    }

}
