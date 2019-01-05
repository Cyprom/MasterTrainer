using System.Linq;
using MasterTrainer.Data.Entities;
using MasterTrainer.DataAccess;
using System.Collections.Generic;

namespace MasterTrainer.Business.Repositories
{
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
