namespace MasterTrainer.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class UniqueUserFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "RegisteredOn", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            CreateIndex("dbo.Users", "Name", unique: true, name: "UC_UserName");
            CreateIndex("dbo.Users", "Email", unique: true, name: "UC_UserEmail");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", "UC_UserEmail");
            DropIndex("dbo.Users", "UC_UserName");
            DropColumn("dbo.Users", "RegisteredOn");
        }
    }
}
