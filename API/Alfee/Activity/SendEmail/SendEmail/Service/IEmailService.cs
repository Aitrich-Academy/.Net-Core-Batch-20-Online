using SendEmail.Model;

namespace SendEmail.Service
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
