namespace Job_Portal.API.JobProvider.RequestObjects
{
    public class VerifyEmailRequest
    {
        public string Email { get; set; } = null!;
        public string OTP { get; set; } = null!;
    }
}