namespace MasterTrainer.Business.AuthenticationManagement.Services
{
    public interface IPasswordService
    {
        string CreateHash(string password);
        bool VerifyPassword(string password, string storedHash);
    }
}
