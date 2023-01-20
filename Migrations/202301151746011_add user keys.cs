namespace E_Apartments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adduserkeys : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CustomerSaves", "UserId", "dbo.Users");
            DropIndex("dbo.CustomerSaves", new[] { "UserId" });
            DropColumn("dbo.CustomerSaves", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CustomerSaves", "UserId", c => c.Guid());
            CreateIndex("dbo.CustomerSaves", "UserId");
            AddForeignKey("dbo.CustomerSaves", "UserId", "dbo.Users", "UserId");
        }
    }
}
