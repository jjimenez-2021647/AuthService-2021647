namespace AuthServiceIN6BM.Application.Interfaces;

public interface IEmailService
{   
    Task SendEmailVerificationAsync(string email, string username, string token);
    Task SendPasswordResetAsync(string email, string username, string token);
    Task SenWelcomeEmailAsync(string email, string username);

}




















