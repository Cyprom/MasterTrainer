namespace MasterTrainer.Business.Mappers
{
    public interface IUserMapper
    {
        DataContracts.Client.User Map(Data.Entities.User user);
    }
}
