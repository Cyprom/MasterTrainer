using MasterTrainer.DataContracts.Client;

namespace MasterTrainer.Business.Services
{
    public interface IRegistrationService
    {
        User Register(string name, string password, string confirmation);
    }    
}
