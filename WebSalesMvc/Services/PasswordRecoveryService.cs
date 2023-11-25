using Microsoft.Extensions.Logging;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

public class PasswordRecoveryService
{
    private readonly ILogger<PasswordRecoveryService> _logger;

    public PasswordRecoveryService(ILogger<PasswordRecoveryService> logger)
    {
        _logger = logger;

    }
    public async Task SendEmailAsync(string toEmail, string subject, string message, string fromEmail, string fromName)
    {
        _logger.LogInformation("Attempting to send email...");

        try
        {
            string apiKey = Environment.GetEnvironmentVariable("SendGrid:ApiKey", EnvironmentVariableTarget.User);
            var client = new SendGridClient(apiKey);

            _logger.LogInformation("SendGrid API Key: {ApiKey}", apiKey);

            var from = new EmailAddress(fromEmail, fromName);
            var to = new EmailAddress(toEmail);
            
            var plainTextContent = "and easy to do anywhere, even with C#";

            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";

            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

            var response = await client.SendEmailAsync(msg);

            if (response != null && (response.StatusCode == System.Net.HttpStatusCode.OK ||
                                   response.StatusCode == System.Net.HttpStatusCode.Accepted))
            {

                _logger.LogInformation("Email sent successfully", response, msg);

            }
            else
            {
            _logger.LogError("Failed to send email. Response: {@Response}", response, msg);
            }
        }
            

        catch (Exception ex)
        {
            _logger.LogError(ex, "Error sending email.");
            throw; 
        }
    }

}
