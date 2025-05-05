using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise.Interface;
using Excercise.Model;

namespace Excercise.Repository
{
    public class InterviewRepository : IInterviewInterface
    {
        List<Interview> interviews = new List<Interview>();
        public void listInterview()
        {
            Console.WriteLine("All interviews list....");
            foreach (var inter in interviews)
            {
                Console.WriteLine("ID :{0} || Name :{1} || Date :{2} || Location :{3}",inter.Id ,inter.Post_Name,inter.Date,inter.Location);            
            }
        }
        public void scheduleInterview(Interview inter)
        {
            interviews.Add(inter);
        }
    }
}
