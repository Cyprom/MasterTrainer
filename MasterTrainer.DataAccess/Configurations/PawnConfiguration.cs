using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using MasterTrainer.Data.Entities;

namespace MasterTrainer.DataAccess.Configurations
{
    public class PawnConfiguration : EntityTypeConfiguration<Pawn>
    {
        public PawnConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
