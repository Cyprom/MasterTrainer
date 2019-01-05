using MasterTrainer.DataContracts.UserManagement;

namespace MasterTrainer.Business.RegistrationManagement.Services
{
    public interface IRegistrationService
    {
        User Register(string name, string email, string password, string confirmation);
    }    
}
