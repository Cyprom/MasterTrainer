using MasterTrainer.DataContracts.Client;

namespace MasterTrainer.Business.Services
{
    public interface IAuthenticationService
    {
        User Authenticate(string name, string password);
    }
}
