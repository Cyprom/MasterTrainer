namespace MasterTrainer.Business.Mappers
{
    public class UserMapper : IUserMapper
    {
        public DataContracts.Client.User Map(Data.Entities.User entity)
        {
            return new DataContracts.Client.User()
            {
                Id = entity.Id,

                Name = entity.Name,

                RegisteredOn = entity.RegisteredOn
            };
        }
    }
}
