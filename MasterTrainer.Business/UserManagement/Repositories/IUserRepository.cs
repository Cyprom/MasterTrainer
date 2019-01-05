namespace MasterTrainer.Business.UserManagement.Repositories
{
    using System.Collections.Generic;
    using MasterTrainer.Data.UserManagement;

    public interface IUserRepository
    {
        ICollection<User> SelectAll();
        User Select(int id);
        User SelectByName(string name);
        User SelectByEmail(string email);
        User Update(User user, ICollection<string> propertiesToUpdate = null);
    }
}
