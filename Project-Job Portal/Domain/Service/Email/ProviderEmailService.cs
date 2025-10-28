using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Domain.Helper;
using Domain.Service.Email.Interface;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MimeKit;
using SmtpClient = System.Net.Mail.SmtpClient;


    namespace Domain.Service.Email
    {
        public class ProviderEmailService : IProviderEmailService
        {
            private readonly MailSettings _mailSettings;

            public ProviderEmailService(IOptions<MailSettings> mailSettings)
            {
                _mailSettings = mailSettings.Value;
            }

            public async Task SendEmailAsync(string toEmail, string subject, string body)
            {
                try
                {
                    using var smtp = new SmtpClient(_mailSettings.Host, _mailSettings.Port)
                    {
                        Credentials = new NetworkCredential(_mailSettings.UserMail, _mailSettings.Password),
                        EnableSsl = _mailSettings.EnableSsl // if added
                    };

                    var mailMessage = new MailMessage
                    {
                        From = new MailAddress(_mailSettings.UserMail, _mailSettings.DisplayName),
                        Subject = subject,
                        Body = body,
                        IsBodyHtml = true
                    };

                    mailMessage.To.Add(toEmail);

                    await smtp.SendMailAsync(mailMessage);
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("Failed to send email.", ex);
                }
            }
        }
    }
