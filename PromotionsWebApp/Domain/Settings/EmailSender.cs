﻿using PromotionsWebApp.Domain.Entities;
using PromotionsWebApp.Utilities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace PromotionsWebApp.Domain.Settings
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailMetadata _emailConfig;

        public EmailSender(EmailMetadata emailConfig)
        {
            _emailConfig = emailConfig;

        }

        private async Task SendEmailAsync(EmailMessage model)
        {
            string sMessage;
            SmtpClient smtpClient = new SmtpClient();

            MailMessage message = new MailMessage();
            try
            {

                MailAddress fromAddress = new MailAddress(_emailConfig.Sender, "Promotions Web App");
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Host = _emailConfig.SmtpServer;
                smtpClient.Port = _emailConfig.Port;
                message.From = fromAddress;

                MailAddress toAddress = new MailAddress(model.To);
                message.To.Add(toAddress);
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new System.Net.NetworkCredential(_emailConfig.UserName, _emailConfig.Password);

                message.Subject = model.Subject;
                message.Body = model.Content;
                message.IsBodyHtml = true;

                if (model.Attachment != null)
                {
                    message.Attachments.Add(new Attachment(new MemoryStream(model.Attachment.Content), model.Attachment.FileName));
                }
                smtpClient.Send(message);
                sMessage = "Email sent.";

            }
            catch (Exception ex)
            {
                sMessage = "Coudn't send the message!\n " + ex.Message;
                throw;
            }

        }

        public async Task SendEmailPasswordReset(string emailAddress, string link)
        {
            EmailMessage message = new EmailMessage(emailAddress, "Promotions Web App Reset Password", CreateResetPasswordText(link));
            await SendEmailAsync(message);
        }
        public async Task SendLoginDetails(string emailAddress, string userName, string password)
        {
            EmailMessage message = new EmailMessage(emailAddress, "Promotions Web App Login Details", CreateLoginDetailsText(userName, password));
            await SendEmailAsync(message);
        }
        public async Task SendNewUserDetails(string emailAddress, string userName, string password, string link)
        {
            EmailMessage message = new EmailMessage(emailAddress, "Promotions Web App New User", CreateNewUserText(userName, password, link));
            await SendEmailAsync(message);
        }
        public async Task SendInboxNotification(string email, string link)
        {
            EmailMessage message = new EmailMessage(email, "Promotions Web App Inbox", CreateInboxNotificationText(link));
            await SendEmailAsync(message);
        }
        public async Task SendPromotionApproved(string email,string link)
        {
            EmailMessage message = new EmailMessage(email, "Promotion Accepted", CreatePromotionApproved(link));
            await SendEmailAsync(message);
        }
        public async Task SendPromotionRejected(string email,string link)
        {
            EmailMessage message = new EmailMessage(email, "Promotion Rejected", CreatePromotionRejected(link));
            await SendEmailAsync(message);
        }
        private string CreatePromotionApproved(string Link)
        {
            var output = "";
            output = string.Format("<p>Good Day,</p><p>Your promotion application has been approved</p>" +
                                    "<p>Please log into system to view its progress</p>" +
                                    "<p>{0}</p><br/>" +
                                    "<p>Kind Regards,<br/>Administrator<br/>Promotions Web App</p>", Link);
            return output;
        }
        private string CreatePromotionRejected(string Link)
        {
            var output = "";
            output = string.Format("<p>Good Day,</p><p>Your promotion application has been rejected</p>" +
                                    "<p>Please log into system to view the reason</p>" +
                                    "<p>{0}</p><br/>" +
                                    "<p>Kind Regards,<br/>Administrator<br/>Promotions Web App</p>", Link);
            return output;
        }
        private string CreateResetPasswordText(string Link)
        {
            var output = "";
            output = string.Format("<p>Good Day,</p><p>You have requested to change your password on the Promotions Web App System</p>" +
                                    "<p>Please use the following link to change your password</p>" +
                                    "<p>{0}</p><br/>" +
                                    "<p>Kind Regards,<br/>Administrator<br/>Promotions Web App</p>", Link);
            return output;
        }
        private string CreateLoginDetailsText(string userName, string Link)
        {
            var output = "";
            output = string.Format("<p>Good Day,</p><p>You have requested your Login Details on the Promotions Web App System</p>" +
                                    "<p>Please find them below</p>" +
                                    "<p>Username: {0}</p>" +
                                    "<p>If you need to reset your password please follow the link below</p>" +
                                    "<p>{1}</p>" +
                                    "<p>Kind Regards,<br/>Administrator<br/>Promotions Web App</p>", userName, Link);
            return output;
        }
        private string CreateNewUserText(string userName, string password, string link)
        {
            var output = "";
            output = string.Format("<p>Good Day,</p><p>An account has been created for you on the Promotions Web App SYSTEM</p>" +
                                    "<p>Please find Login Details below:</p>" +
                                    "<p>Username: {0}</p>" +
                                    "<p>Password: {1}</p><br/>" +
                                     "<p>Please login to change your password</p>" +
                                    "<p>{2}</p>" +
                                     "<p>Kind Regards,<br/>Administrator<br/>Promotions Web App</p>", userName, password, link);
            return output;
        }
        private string CreateInboxNotificationText(string link)
        {
            var output = "";
            output = string.Format("<p>Good Day,</p><p>There are some items in your inbox that require your attention/p>" +
                                    "<p>Please attend to them.</p>" +
                                    "<p>{0}</p>" +
                                     "<p>Kind Regards,<br/>Administrator<br/>Promotions Web App</p>", link);
            return output;
        }


    }
}
