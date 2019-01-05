namespace MasterTrainer.Business.AuthenticationManagement.Services
{
    using MasterTrainer.DataContracts.UserManagement;

    public interface IAuthenticationService
    {
        User Authenticate(string email, string password);
    }
}
