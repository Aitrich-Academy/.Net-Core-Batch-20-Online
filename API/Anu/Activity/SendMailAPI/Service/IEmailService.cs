using SendMailAPI.Helper;

namespace SendMailAPI.Service
{
    public interface  IEmailService
    {
        Task SendEmailAsync(MailRequest mailrequest);
    }
}
