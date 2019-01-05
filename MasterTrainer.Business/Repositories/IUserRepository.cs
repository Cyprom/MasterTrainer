using System.Collections.Generic;
using MasterTrainer.Data.Entities;

namespace MasterTrainer.Business.Repositories
{
    public interface IUserRepository
    {
        ICollection<User> SelectAll();
        User Select(int id);
        User SelectByName(string name);
        User Create(User user);
        User Update(User user, ICollection<string> propertiesToUpdate = null);
    }
}
