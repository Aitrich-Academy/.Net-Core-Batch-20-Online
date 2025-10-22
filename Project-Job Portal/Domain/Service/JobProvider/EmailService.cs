using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Domain.Service.JobProvider.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Domain.Service.JobProvider
{
    using MailKit.Net.Smtp;
    using MimeKit;
    using Microsoft.Extensions.Configuration;
    using System.Threading.Tasks;

    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string toEmail, string subject, string body)
        {
            var mailSettings = _configuration.GetSection("MailSettings");

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(mailSettings["DisplayName"], mailSettings["FromMail"]));
            message.To.Add(MailboxAddress.Parse(toEmail));
            message.Subject = subject;

            // Body
            message.Body = new TextPart("html")
            {
                Text = body
            };

            using var smtp = new SmtpClient();

            // Connect to Gmail SMTP server
            await smtp.ConnectAsync(mailSettings["Host"], int.Parse(mailSettings["Port"]), true); // use SSL

            // Authenticate
            await smtp.AuthenticateAsync(mailSettings["UserMail"], mailSettings["Password"]);

            // Send email
            await smtp.SendAsync(message);

            await smtp.DisconnectAsync(true);
        }
    }
}