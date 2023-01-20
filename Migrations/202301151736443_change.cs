namespace E_Apartments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CustomerSaves", "LeasingId", "dbo.Leasings");
            DropIndex("dbo.CustomerSaves", new[] { "LeasingId" });
            DropColumn("dbo.CustomerSaves", "LeasingId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CustomerSaves", "LeasingId", c => c.Guid());
            CreateIndex("dbo.CustomerSaves", "LeasingId");
            AddForeignKey("dbo.CustomerSaves", "LeasingId", "dbo.Leasings", "LeasingId");
        }
    }
}
