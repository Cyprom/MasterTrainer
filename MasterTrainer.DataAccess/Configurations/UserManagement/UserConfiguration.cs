namespace MasterTrainer.DataAccess.Configurations.UserManagement
{
    using MasterTrainer.Data.UserManagement;
    using System.Data.Entity.ModelConfiguration;
    using System.ComponentModel.DataAnnotations.Schema;
    using MasterTrainer.DataAccess.Extensions;

    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name).IsRequired().HasColumnType(ColumnType.String).HasMaxLength(50).IsUnique("UserName");
            Property(x => x.Password).IsRequired().HasColumnType(ColumnType.String).IsMaxLength();

            Property(x => x.RegisteredOn).IsRequired().HasColumnType(ColumnType.DateTime);
        }
    }
}
