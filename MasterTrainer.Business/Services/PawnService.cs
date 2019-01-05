using System.Data;
using System.Linq;
using System.Collections.Generic;
using MasterTrainer.Business.Repositories;
using MasterTrainer.Business.Mappers;
using MasterTrainer.DataContracts.Client;

namespace MasterTrainer.Business.Services
{
    public class PawnService : IPawnService
    {
        private readonly IPawnMapper pawnMapper;
        private readonly IPawnRepository pawnRepository;

        public PawnService(IPawnMapper pawnMapper, IPawnRepository pawnRepository)
        {
            this.pawnMapper = pawnMapper;
            this.pawnRepository = pawnRepository;
        }

        public ICollection<Pawn> GetAll()
        {
            var entities = pawnRepository.SelectAll().ToList();
            var mapped = entities.Select(x => pawnMapper.Map(x)).ToList();
            return mapped;
        }
    }
}
