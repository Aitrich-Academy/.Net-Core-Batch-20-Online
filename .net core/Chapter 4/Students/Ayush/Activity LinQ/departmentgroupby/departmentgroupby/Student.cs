using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace departmentgroupby
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string department {  get; set; }

        public Student() { }
        public Student(int id, string name, string department)
        {
            Id = id;
            Name = name;
            this.department = department;
        }
    }
}
