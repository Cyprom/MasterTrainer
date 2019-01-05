using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using MasterTrainer.Data.Entities;
using MasterTrainer.DataAccess.Extensions;

namespace MasterTrainer.DataAccess.Configurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).IsRequired().HasColumnType(ColumnTypes.String).HasMaxLength(50).IsUnique("UserName");
            Property(x => x.Password).IsRequired().HasColumnType(ColumnTypes.String).IsMaxLength();
            Property(x => x.RegisteredOn).IsRequired().HasColumnType(ColumnTypes.DateTime);
        }
    }
}
