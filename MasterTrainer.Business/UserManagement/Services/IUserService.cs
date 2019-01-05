namespace MasterTrainer.Business.UserManagement.Services
{
    using System.Collections.Generic;
    using MasterTrainer.DataContracts.UserManagement;

    public interface IUserService
    {
        ICollection<User> GetAll();
        User GetByName(string name);
        User Create(string name, string hashedPassword);
    }
}
