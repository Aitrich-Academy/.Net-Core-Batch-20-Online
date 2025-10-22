namespace Job_Portal.API.JobProvider.Request_Object
{
    public class UpdateJobPostRequest
    {
        public string JobTitle { get; set; } = null!;
        public string JobSummary { get; set; } = null!;
        public Guid LocationId { get; set; }
        public Guid IndustryId { get; set; }
        //public Guid CategoryId { get; set; }
    }
}
