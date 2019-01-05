namespace MasterTrainer.Business.PawnManagement.Repositories
{
    using MasterTrainer.Data.PawnManagement;
    using System.Collections.Generic;

    public interface IPawnRepository
    {
        ICollection<Pawn> SelectAll();
    }
}
