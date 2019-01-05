using System.Data.Entity.Migrations;

namespace MasterTrainer.DataAccess.Migrations
{
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pawns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 4000),
                        RegisteredOn = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "UC_UserName");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", "UC_UserName");
            DropTable("dbo.Users");
            DropTable("dbo.Pawns");
        }
    }
}
