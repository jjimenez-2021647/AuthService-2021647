namespace AuthServiceIN6BM.Application.Interfaces;

public interface IPasswordHashService
{
    string HashPassword(string password);
    bool verifyPassword(string password, string hashedPassword);
    
}