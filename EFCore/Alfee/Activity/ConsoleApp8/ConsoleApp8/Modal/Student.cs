using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Modal
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }

        public ICollection<Mark> Marks { get; set; } = new List<Mark>();
    }
}
