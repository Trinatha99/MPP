using System.Net.Mail;
using System.Net;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Alliance.Controllers
{
    public class EmailController : Controller
    {
        [HttpPost]
        public IActionResult SendApplication(string name, string email, string position, string coverletter)
        {
            try
            {
                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential("rinaranimalik57@gmail.com", "hmxv vadu jzhn tscl");
                    smtpClient.EnableSsl = true;

                    using (MailMessage mailMessage = new MailMessage())
                    {
                        mailMessage.From = new MailAddress("rinaranimalik57@gmail.com");
                        mailMessage.To.Add("tanmay.appman@gmail.com");
                        mailMessage.Subject = "New Application Submission";
                        mailMessage.Body = $"Sender Name: {name}\n" +
                                           $"Sender Email: {email}\n" +
                                           $"Position Applied For: {position}\n" +
                                           $"Cover Letter: {coverletter}";
                        smtpClient.Send(mailMessage);
                    }
                }
                return Ok("Application submitted successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Failed to send application: {ex.Message}");
            }
        }

       
    public IActionResult SendApplication1(string name, string email, string message1)
        {
            try
            {
                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential("rinaranimalik57@gmail.com", "hmxv vadu jzhn tscl");
                    smtpClient.EnableSsl = true;

                    using (MailMessage mailMessage = new MailMessage())
                    {
                        mailMessage.From = new MailAddress("rinaranimalik57@gmail.com");
                        mailMessage.To.Add("tanmay.appman@gmail.com");
                        mailMessage.Subject = "New Application Submission";
                        mailMessage.Body = $"Sender Name: {name}\n" +
                                           $"Sender Email: {email}\n" +
                                           $"Sender Message: {message1}";
                        smtpClient.Send(mailMessage);
                    }
                }
                return Ok("Application submitted successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Failed to send application: {ex.Message}");
            }
        }



        //public IActionResult SendApplication1(string name, string email, string message)
        //{
        //    try
        //    {
        //        using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
        //        {
        //            smtpClient.UseDefaultCredentials = false;
        //            smtpClient.Credentials = new NetworkCredential("rinaranimalik57@gmail.com", "hmxv vadu jzhn tscl");
        //            smtpClient.EnableSsl = true;

        //            using (MailMessage mailMessage = new MailMessage())
        //            {
        //                mailMessage.From = new MailAddress("rinaranimalik57@gmail.com");
        //                mailMessage.To.Add("rinarani.malik@appman.tech");
        //                mailMessage.Subject = "New Application Submission";
        //                mailMessage.Body = $"Sender Name: {name}\n" +
        //                                   $"Sender Email: {email}\n" +
        //                                   $"Sender Message: {message}\n";
        //                smtpClient.Send(mailMessage);
        //            }
        //        }
        //        return Ok("Application submitted successfully.");
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, $"Failed to send application: {ex.Message}");
        //    }
        //}

        public IActionResult SendMail(string name, string number, string email)
        {
            try
            {
                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential("rinaranimalik57@gmail.com", "hmxv vadu jzhn tscl");
                    smtpClient.EnableSsl = true;
                    using (MailMessage mailMessage = new MailMessage())
                    {
                        mailMessage.From = new MailAddress("rinaranimalik57@gmail.com");
                        mailMessage.To.Add("tanmay.appman@gmail.com");
                        mailMessage.Subject = "New Inquiry";
                        mailMessage.Body = $"Sender Name: {name}\n"
                                         + $"Sender Number: {number}\n"
                                         + $"Sender Email: {email}";
                        smtpClient.Send(mailMessage);
                    }
                }
                return Ok("Mail sent successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Failed to send mail: {ex.Message}");
            }
        }
    }
}
