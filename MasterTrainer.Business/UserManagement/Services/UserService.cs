namespace MasterTrainer.Business.UserManagement.Services
{
    using System.Linq;
    using System.Collections.Generic;
    using MasterTrainer.DataContracts.UserManagement;
    using MasterTrainer.Business.UserManagement.Mappers;
    using MasterTrainer.Business.UserManagement.Repositories;

    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IUserMapper userMapper;

        public UserService()
        {
            this.userRepository = new UserRepository();
            this.userMapper = new UserMapper();
        }

        public ICollection<User> GetAll()
        {
            var entities = userRepository.SelectAll().ToList();
            var mapped = entities.Select(x => userMapper.Map(x)).ToList();
            var sorted = mapped.OrderBy(x => x.Name).ToList();
            return sorted;
        }

        public User GetByEmail(string email)
        {
            var user = userRepository.SelectByEmail(email);
            return user != null ? userMapper.Map(user) : null;
        }
    }
}
