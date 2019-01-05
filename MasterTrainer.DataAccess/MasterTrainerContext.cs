namespace MasterTrainer.DataAccess
{
    using System.Data.Entity;
    using MasterTrainer.Data.PawnManagement;
    using MasterTrainer.Data.UserManagement;

    public class MasterTrainerContext : DbContext
    {
        public MasterTrainerContext() : base("name=MasterTrainer")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Pawn> Pawns { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
