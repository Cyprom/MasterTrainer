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
        private readonly IUserMapper userMapper;
        private readonly IUserRepository userRepository;

        public UserService(IUserMapper userMapper, IUserRepository userRepository)
        {
            this.userMapper = userMapper;
            this.userRepository = userRepository;
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

        public User Create(string name, string hashedPassword)
        {
            var entity = new Data.UserManagement.User()
            {
                Name = name,
                Password = hashedPassword,
                RegisteredOn = DateTime.Now
            };

            var user = userRepository.Create(entity);
            return user != null ? userMapper.Map(user) : null;
        }
    }
}
