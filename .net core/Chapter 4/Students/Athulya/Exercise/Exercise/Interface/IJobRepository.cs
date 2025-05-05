using Exercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Interface
{
    public interface IJobRepository
    {
       public List<Jobs> GetJobs();

    }
}
