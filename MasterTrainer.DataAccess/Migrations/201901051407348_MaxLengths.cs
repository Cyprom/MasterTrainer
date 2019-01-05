namespace MasterTrainer.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaxLengths : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 4000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Users", "Name", c => c.String());
        }
    }
}
