using JobSeekerPortal.Enums;

namespace JobSeekerPortal.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public JobType JobType { get; set; }
        public string Location { get; set; } = string.Empty;
        public string SalaryRange { get; set; } = "";
        public int PostedById { get; set; }     // User Id of the company/creator
        public DateTime PostedDate { get; set; } = DateTime.Now;
    }
}
