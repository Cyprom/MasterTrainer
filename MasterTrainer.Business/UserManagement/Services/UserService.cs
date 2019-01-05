namespace MasterTrainer.Business.UserManagement.Services
{
    using System;
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
            userRepository = new UserRepository();
            userMapper = new UserMapper();
        }

        public ICollection<User> GetAll()
        {
            var entities = userRepository.SelectAll().ToList();
            var mapped = entities.Select(x => userMapper.Map(x)).ToList();
            var sorted = mapped.OrderBy(x => x.Name).ToList();
            return sorted;
        }

        public User GetByName(string name)
        {
            var user = userRepository.SelectByName(name);
            return user != null ? userMapper.Map(user) : null;
        }

        public User GetByEmail(string email)
        {
            var user = userRepository.SelectByEmail(email);
            return user != null ? userMapper.Map(user) : null;
        }

        public User Create(string name, string email, string hashedPassword)
        {
            var entity = new Data.UserManagement.User()
            {
                Name = name,
                Email = email,
                Password = hashedPassword,
                RegisteredOn = DateTime.Now
            };

            var user = userRepository.Create(entity);
            return user != null ? userMapper.Map(user) : null;
        }
    }
}
