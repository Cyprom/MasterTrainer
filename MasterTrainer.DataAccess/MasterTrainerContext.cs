using System.Data.Entity;
using MasterTrainer.Data.Entities;
using MasterTrainer.DataAccess.Configurations;

namespace MasterTrainer.DataAccess
{
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
