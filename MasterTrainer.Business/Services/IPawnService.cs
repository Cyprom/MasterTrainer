using System.Collections.Generic;
using MasterTrainer.DataContracts.Client;

namespace MasterTrainer.Business.Services
{
    public interface IPawnService
    {
        ICollection<Pawn> GetAll();
    }
}
