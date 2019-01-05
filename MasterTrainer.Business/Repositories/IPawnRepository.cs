using MasterTrainer.Data.Entities;
using System.Collections.Generic;

namespace MasterTrainer.Business.Repositories
{
    public interface IPawnRepository
    {
        ICollection<Pawn> SelectAll();
    }
}
