using System.Collections.Generic;
using MasterTrainer.DataContracts.Client;

namespace MasterTrainer.Business.Services
{
    public interface IUserService
    {
        ICollection<User> GetAll();
        User GetByName(string name);
        User Create(string name, string hashedPassword);
    }
}
