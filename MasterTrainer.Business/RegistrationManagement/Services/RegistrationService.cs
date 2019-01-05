using MasterTrainer.Business.AuthenticationManagement.Services;
using MasterTrainer.Business.RegistrationManagement.Exceptions;
using MasterTrainer.Business.UserManagement.Services;
using MasterTrainer.Configuration;
using MasterTrainer.DataContracts.UserManagement;

namespace MasterTrainer.Business.RegistrationManagement.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IPasswordService passwordService;
        private readonly IUserService userService;

        public RegistrationService(IPasswordService passwordService, IUserService userService)
        {
            this.passwordService = passwordService;
            this.userService = userService;
        }

        public User Register(string name, string password, string confirmation)
        {
            if (password.Length < RegistrationConfiguration.MinimumPasswordLength)
            {
                throw new RegistrationException($"The password should be at least {RegistrationConfiguration.MinimumPasswordLength} characters long!");
            }

            if (password != confirmation)
            {
                throw new RegistrationException("The passwords do not match!");
            }

            var userByName = userService.GetByName(name);
            if (userByName != null)
            {
                throw new RegistrationException($"There is already a user with the name '{name}'!");
            }

            var hashedPassword = passwordService.CreateHash(password);
            var user = userService.Create(name, hashedPassword);

            return user;
        }
    }    
}
