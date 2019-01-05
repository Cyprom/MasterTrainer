namespace MasterTrainer.Business.PawnManagement.Repositories
{
    using System.Linq;
    using MasterTrainer.Data.PawnManagement;
    using MasterTrainer.DataAccess;
    using System.Collections.Generic;

    public class PawnRepository : IPawnRepository
    {
        public ICollection<Pawn> SelectAll()
        {
            using (var context = new MasterTrainerContext())
            {
                return context.Pawns.ToList();
            }
        }
    }
}
