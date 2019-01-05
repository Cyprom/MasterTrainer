using System;
using System.Linq;
using System.Collections.Generic;
using MasterTrainer.Data.Entities;
using MasterTrainer.DataAccess;

namespace MasterTrainer.Business.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserRepository() : base() { }

        public ICollection<User> SelectAll()
        {
            using (var context = new MasterTrainerContext())
            {
                return context.Users.ToList();
            }
        }

        public User Select(int id)
        {
            using (var context = new MasterTrainerContext())
            {
                return context.Users.SingleOrDefault(x => x.Id == id);
            }
        }

        public User SelectByName(string name)
        {
            using (var context = new MasterTrainerContext())
            {
                return context.Users.SingleOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            }
        }
        
        public User Create(User user)
        {
            using (var context = new MasterTrainerContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
                return user;
            }
        }

        public User Update(User user, ICollection<string> propertiesToUpdate = null)
        {
            using (var context = new MasterTrainerContext())
            {
                var existing = context.Users.SingleOrDefault(x => x.Id == user.Id);
                if (existing != null)
                {
                    var properties = typeof(User).GetProperties();
                    if (propertiesToUpdate != null)
                    {
                        properties = properties.Where(x => propertiesToUpdate.Contains(x.Name)).ToArray();
                    }
                    foreach (var property in properties)
                    {
                        if (property.Name != "Id")
                        {
                            property.SetValue(existing, property.GetValue(user));
                        }
                    }
                }
                context.SaveChanges();

                return existing;
            }
        }
    }
}
