namespace MasterTrainer.Business.PawnManagement.Services
{
    using System.Data;
    using System.Linq;
    using System.Collections.Generic;
    using MasterTrainer.Business.PawnManagement.Repositories;
    using MasterTrainer.Business.PawnManagement.Mappers;
    using MasterTrainer.DataContracts.PawnManagement;

    public class PawnService : IPawnService
    {
        private readonly IPawnRepository pawnRepository;
        private readonly IPawnMapper pawnMapper;

        public PawnService()
        {
            pawnRepository = new PawnRepository();
            pawnMapper = new PawnMapper();
        }

        public ICollection<Pawn> GetAll()
        {
            var entities = pawnRepository.SelectAll().ToList();
            var mapped = entities.Select(x => pawnMapper.Map(x)).ToList();
            return mapped;
        }
    }
}
