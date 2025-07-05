namespace UserManagement.Models
{
    public class AppliedJob
    {
        public int AppliedJobId { get; set; }
        public int UserId { get; set; }
        public int JobId { get; set; }


        public string JobTitle { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public DateTime AppliedJobDate { get; set; } = DateTime.Now;
    }
}
