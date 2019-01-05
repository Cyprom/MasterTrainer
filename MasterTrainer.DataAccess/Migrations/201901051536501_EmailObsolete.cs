namespace MasterTrainer.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class EmailObsolete : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Users", "UC_UserEmail");
            DropColumn("dbo.Users", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 200));
            CreateIndex("dbo.Users", "Email", unique: true, name: "UC_UserEmail");
        }
    }
}
