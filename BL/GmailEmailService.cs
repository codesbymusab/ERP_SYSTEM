using ERP_System.DTO;
using MailKit.Net.Smtp;
using MimeKit;
using System.Collections.Generic;
using System.Net.Mail;
using System.Threading.Tasks;

public class GmailEmailService
{
    public async Task SendEmailAsync(string toEmail, string subject, string body)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress("ERP System", "asmenterpriseerp@gmail.com"));
        message.To.Add(MailboxAddress.Parse(toEmail));
        message.Subject = subject;
        message.Body = new TextPart("plain") { Text = body };

        var client = new MailKit.Net.Smtp.SmtpClient();
        await client.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
        await client.AuthenticateAsync("asmenterpriseerp@gmail.com", "kmiv sosc tbgi jsky");
        await client.SendAsync(message);
        await client.DisconnectAsync(true);
    }

    public async Task SendOtpAsync(string userEmail, string otp)
    {
        var subject = "Your Login OTP";
        var body = $"Your one-time password is: {otp}\nIt expires in 5 minutes.";
   
        await SendEmailAsync(userEmail, subject, body);
    }

    public async Task SendLowStockAlertAsync(List<ProductDTO> lowStockItems, string managerEmail = "masabmuhammad2005@gmail.com")
    {
        var subject = "Low Stock Alert";
        var body = "The following items are below minimum stock:\n\n";

        foreach (var item in lowStockItems)
        {
            body += $"- {item.Name}: {item.Stock} units remaining\n";
        }

        
        await SendEmailAsync(managerEmail, subject, body);
    }

}
