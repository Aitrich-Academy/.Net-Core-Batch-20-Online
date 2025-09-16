using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SendMailAPI.Helper;
using SendMailAPI.Service;

namespace SendMailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomController : ControllerBase
    {
        private readonly IEmailService emailService;
        public CustomController(IEmailService _emailService)
        {
            this.emailService = _emailService;
        }

        [HttpPost]
        public async Task<IActionResult> SendMail()
        {
            try
            {
                MailRequest mailrequest = new MailRequest();
                mailrequest.ToEmail = "muhnasif777@gmail.com";
                mailrequest.Subject = "hai";
                mailrequest.Body = "How r u nazeer!";
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
