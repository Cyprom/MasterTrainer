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
            this.passwordService = new PasswordService();
            this.userRepository = new UserRepository();
            this.userMapper = new UserMapper();
        }

        public User Authenticate(string email, string password)
        {
            var user = userRepository.SelectByEmail(email);
            if (user != null && passwordService.VerifyPassword(password, user.Password))
            {
                return userMapper.Map(user);
            }
            return null;
        }

    }
}
