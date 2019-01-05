namespace MasterTrainer.Business.AuthenticationManagement.Services
{
    using MasterTrainer.DataContracts.UserManagement;
    using MasterTrainer.Business.UserManagement.Mappers;
    using MasterTrainer.Business.UserManagement.Repositories;

    public class AuthenticationService : IAuthenticationService
    {
        private readonly IPasswordService passwordService;
        private readonly IUserRepository userRepository;
        private readonly IUserMapper userMapper;

        public AuthenticationService()
        {
            passwordService = new PasswordService();
            userRepository = new UserRepository();
            userMapper = new UserMapper();
        }

        public User Authenticate(string name, string password)
        {
            var user = userRepository.SelectByName(name);
            if (user != null && passwordService.VerifyPassword(password, user.Password))
            {
                return userMapper.Map(user);
            }
            return null;
        }
    }
}
