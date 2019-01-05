namespace MasterTrainer.Business.PawnManagement.Mappers
{
    public class PawnMapper : IPawnMapper
    {
        public DataContracts.PawnManagement.Pawn Map(Data.PawnManagement.Pawn entity)
        {
            return new DataContracts.PawnManagement.Pawn()
            {
                Id = entity.Id
            };
        }
    }
}
