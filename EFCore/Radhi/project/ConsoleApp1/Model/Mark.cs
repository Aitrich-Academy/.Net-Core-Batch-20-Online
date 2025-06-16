using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class Mark
    {
        public int MarkId { get; set; }
        [ForeignKey("Student")]
        public int Student_Id { get; set; }
        public Student Student { get; set; }




        public int M1 { get; set; }
        public int M2 { get; set; }
        public int M3 { get; set; }
    }
}
