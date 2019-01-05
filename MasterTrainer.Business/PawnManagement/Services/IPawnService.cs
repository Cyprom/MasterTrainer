namespace MasterTrainer.Business.PawnManagement.Services
{
    using System.Collections.Generic;
    using MasterTrainer.DataContracts.PawnManagement;

    public interface IPawnService
    {
        ICollection<Pawn> GetAll();
    }
}
