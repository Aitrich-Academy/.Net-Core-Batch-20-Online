using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markstudent
{
    public class Student
    {
        public int id;
        public string name;
        public int mark;

        public Student() { }
        
        public Student(int id,string name,int mark)
        {
            this.id = id;
            this.name = name;
            this.mark = mark;

        }
    }
}
