namespace MasterTrainer.Business.UserManagement.Mappers
{
    public interface IUserMapper
    {
        DataContracts.UserManagement.User Map(Data.UserManagement.User user);
    }
}
