namespace MasterTrainer.Business.UserManagement.Services
{
    using System.Collections.Generic;
    using MasterTrainer.DataContracts.UserManagement;

    public interface IUserService
    {
        ICollection<User> GetAll();
        User GetByName(string name);
        User GetByEmail(string email);
        User Create(string name, string email, string hashedPassword);
    }
}
