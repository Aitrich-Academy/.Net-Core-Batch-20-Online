namespace JobSeekerPortal.Dtos
{
    public class ApplicationDto
    {
        public int Id { get; set; }
        public int JobId { get; set; }        // Which job was applied
        public int UserId { get; set; }       // Who applied
        public DateTime AppliedDate { get; set; }
    }
}
