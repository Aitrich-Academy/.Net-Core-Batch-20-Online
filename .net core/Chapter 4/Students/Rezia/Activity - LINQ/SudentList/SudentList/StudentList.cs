using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudentList
{
    internal class StudentList
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public StudentList() { }

        public StudentList(int id, string name)
        {
            Id = id;
            Name = name;

        }
        public override string ToString()
        {
            return $"ID : {Id}, Name : {Name}";
        }
    }
}
