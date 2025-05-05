using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqGrade
{
    internal class Student
    {
        public int ID;
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(int id, string name, int grade)
        {
         ID = id;
            Name = name;
            Grade = grade;
        }
        public override string ToString()
        {
            return $"Id : {ID},Name : {Name}, Grade : {Grade}";
        }
    }


}
