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

        public RegistrationService()
        {
            passwordService = new PasswordService();
            userService = new UserService();
        }

        public User Register(string name, string email, string password, string confirmation)
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

            var userByEmail = userService.GetByEmail(email);
            if (userByEmail != null)
            {
                throw new RegistrationException($"The email address '{email}' is already in use!");
            }

            var hashedPassword = passwordService.CreateHash(password);
            var user = userService.Create(name, email, hashedPassword);

            return user;
        }
    }    
}
