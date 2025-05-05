using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise.Model
{
    public class Jobs
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }

        public Jobs(int jobId, string jobName, int salary, string type, string location)
        {
            JobId = jobId;
            JobName = jobName;
            Salary = salary;
            Type = type;
            Location = location;
        }
        public Jobs() { }
    }
}
