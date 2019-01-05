namespace MasterTrainer.Business.Services
{
    public interface IPasswordService
    {
        string CreateHash(string password);
        bool VerifyPassword(string password, string storedHash);
    }
}
