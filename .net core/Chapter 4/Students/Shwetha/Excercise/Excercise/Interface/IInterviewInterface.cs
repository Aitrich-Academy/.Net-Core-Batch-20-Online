using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise.Model;

namespace Excercise.Interface
{
    public interface IInterviewInterface
    {
        public void listInterview();
        public void scheduleInterview(Interview inter);
    }
}
