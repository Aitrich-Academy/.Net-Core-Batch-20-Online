using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewExcersice.Enum;

namespace NewExcersice.Model
{
    public class Job
    {
        public int JobId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Company { get; set; }
        public Roles roles{ get; set; }
        public decimal SalaryRange { get; set; }
    }
}
