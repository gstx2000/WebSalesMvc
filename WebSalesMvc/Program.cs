using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SendGrid.Helpers.Mail;
using SendGrid;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebSalesMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            TrySendEmailAsync().Wait();

        }

            static async Task TrySendEmailAsync()
            {
                var apiKey = Environment.GetEnvironmentVariable("SendGrid:ApiKey");
                var client = new SendGridClient(apiKey);
                var from = new EmailAddress("gst203002@gmail.com", "Gabriel");
                var subject = "Sending with SendGrid is Fun";
                var to = new EmailAddress("edrisnts@gmail.com", "teste");
                var plainTextContent = "and easy to do anywhere, even with C#";
                var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                var response = await client.SendEmailAsync(msg);

                if (response != null && response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Email sent successfully!");
                }
                else
                {
                    Console.WriteLine($"Failed to send email. Response: {response?.StatusCode}");
                }
            }
        


    public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
