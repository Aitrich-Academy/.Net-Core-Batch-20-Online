using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQActivity2
{
    internal class Enrollments
    {
        public int Id { get; set; }
        public string Course { get; set; }

        public Enrollments(int id, string course)
        {
            Id = id;
            Course = course;
        }
        public Enrollments() { }
    }
}
