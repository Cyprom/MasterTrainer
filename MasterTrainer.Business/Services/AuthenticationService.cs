using MasterTrainer.DataContracts.Client;
using MasterTrainer.Business.Mappers;
using MasterTrainer.Business.Repositories;

namespace MasterTrainer.Business.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IPasswordService passwordService;
        private readonly IUserMapper userMapper;
        private readonly IUserRepository userRepository;

        public AuthenticationService(IPasswordService passwordService, IUserMapper userMapper, IUserRepository userRepository)
        {
            this.passwordService = passwordService;
            this.userMapper = userMapper;
            this.userRepository = userRepository;
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
