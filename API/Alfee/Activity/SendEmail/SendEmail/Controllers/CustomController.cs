using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SendEmail.Model;
using SendEmail.Service;

namespace SendEmail.Controllers
{
    [Route("api/Custom")]
    [ApiController]
    public class CustomController : ControllerBase
    {
        private readonly IEmailService emailService;
        public CustomController(IEmailService emailService)
        {
            this.emailService = emailService;
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail()
        {
            try
            {
                MailRequest mailrequest = new MailRequest();
                mailrequest.ToEmail = "ajmalaju06@gmail.com";
                mailrequest.Subject = "Welcome";
                mailrequest.Body = "Thank you for your mail.";
                await emailService.SendEmailAsync(mailrequest);
                return Ok();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
