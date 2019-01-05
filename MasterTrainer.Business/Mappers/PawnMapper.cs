namespace MasterTrainer.Business.Mappers
{
    public class PawnMapper : IPawnMapper
    {
        public DataContracts.Client.Pawn Map(Data.Entities.Pawn entity)
        {
            return new DataContracts.Client.Pawn()
            {
                Id = entity.Id
            };
        }
    }
}
