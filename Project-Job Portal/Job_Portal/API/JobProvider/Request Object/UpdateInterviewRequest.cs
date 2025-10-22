namespace Job_Portal.API.JobProvider.Request_Object
{
    public class UpdateInterviewRequest
    {
        public DateTime Date { get; set; }
        public string Time { get; set; } = null!;
        public string Mode { get; set; } = null!;
        public string Link { get; set; } = null!;
    }
}
