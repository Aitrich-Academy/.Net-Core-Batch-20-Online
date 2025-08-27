namespace JobSeekerPortal.Models
{
    public class Application
    {
        public int Id { get; set; }
        public int JobId { get; set; }        // Which job is applied
        public int UserId { get; set; }       // Who applied
        public DateTime AppliedDate { get; set; } = DateTime.Now;
    }
}
