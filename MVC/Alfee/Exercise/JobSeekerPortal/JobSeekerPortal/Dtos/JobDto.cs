using JobSeekerPortal.Enums;

namespace JobSeekerPortal.Dtos
{
    public class JobDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public JobType JobType { get; set; }
        public string Location { get; set; } = string.Empty;
        public string SalaryRange { get; set; } = "";
        public DateTime PostedDate { get; set; }
    }
}
