using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join
{
    internal class EmployeePost
    {
        public int EmployeeId { get; set; }
        public string EmpPost {  get; set; }

        public EmployeePost() { }
        public EmployeePost(int eid, string ePost)
        {
            EmployeeId = eid;
            EmpPost = ePost;
        }
    }
}
