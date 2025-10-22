namespace Job_Portal.API.JobProvider.Request_Object
{
    public class UpdateInterviewStatusRequest
    {
        public string Status { get; set; } = null!; // Scheduled/Completed/Cancelled
    }
}
