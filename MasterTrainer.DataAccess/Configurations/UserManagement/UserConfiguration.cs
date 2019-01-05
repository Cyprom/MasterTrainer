namespace MasterTrainer.DataAccess.Configurations.UserManagement
{
    using MasterTrainer.Data.UserManagement;
    using System.Data.Entity.ModelConfiguration;
    using System.ComponentModel.DataAnnotations.Schema;
    using MasterTrainer.Constants;

    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name).IsRequired().HasColumnType(Database.ColumnType.String).HasMaxLength(50);
            Property(x => x.Email).IsRequired().HasColumnType(Database.ColumnType.String).HasMaxLength(200);
            Property(x => x.Password).IsRequired().HasColumnType(Database.ColumnType.String).IsMaxLength();
        }
    }
}
