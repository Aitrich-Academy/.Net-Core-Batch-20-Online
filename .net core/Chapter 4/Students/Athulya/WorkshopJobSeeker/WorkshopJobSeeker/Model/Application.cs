using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopJobSeeker.Model
{
   public class Application
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Experience { get; set; }
        public string Location { get; set; }
        public string Qualification { get; set; }

        public Application() { }
        public Application(int jobId,string applicantName,string location,string qualification,string experience)
        {
          this.  Id = jobId;
          this.  Name = applicantName;
           this. Experience = experience;
          this.  Location = location;
           this. Qualification = qualification;

        }
    }
}
