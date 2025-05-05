using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinStudentEnrollment
{
    internal class Enrollment
    {
        public int StudId;
        public string CourseName;

        public Enrollment(int sid, string name)
        {
            StudId = sid;
            CourseName = name;
        }
        public Enrollment() { }
    }
}
