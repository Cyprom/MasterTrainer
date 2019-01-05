namespace MasterTrainer.DataAccess
{
    using System.Data.Entity;
    using MasterTrainer.Data.PawnManagement;
    using MasterTrainer.Data.UserManagement;
    using MasterTrainer.DataAccess.Configurations.PawnManagement;
    using MasterTrainer.DataAccess.Configurations.UserManagement;

    public class MasterTrainerContext : DbContext
    {
        public MasterTrainerContext() : base("name=MasterTrainer")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Pawn> Pawns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new PawnConfiguration());
        }
    }
}
