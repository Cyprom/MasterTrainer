namespace MasterTrainer.Business.UserManagement.Mappers
{
    public class UserMapper : IUserMapper
    {
        public DataContracts.UserManagement.User Map(Data.UserManagement.User entity)
        {
            return new DataContracts.UserManagement.User()
            {
                Id = entity.Id,

                Name = entity.Name,
                Email = entity.Email,

                RegisteredOn = entity.RegisteredOn
            };
        }
    }
}
