using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class Student
    {
        [Key]
        public int Student_Id { get; set; }
        public string Name { get; set; }

        public string Mobileno { get; set; }
        public ICollection<Mark> Marks { get; set; } = new List<Mark>();
    }
}
