namespace E_Apartments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changekeys : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CustomerLeasings", "CustomerId", "dbo.CustomerSaves");
            DropForeignKey("dbo.CustomerLeasings", "LeasingId", "dbo.Leasings");
            DropIndex("dbo.CustomerLeasings", new[] { "CustomerId" });
            DropIndex("dbo.CustomerLeasings", new[] { "LeasingId" });
            AddColumn("dbo.CustomerSaves", "LeasingId", c => c.Guid());
            CreateIndex("dbo.CustomerSaves", "LeasingId");
            AddForeignKey("dbo.CustomerSaves", "LeasingId", "dbo.Leasings", "LeasingId");
            DropTable("dbo.CustomerLeasings");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CustomerLeasings",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CustomerId = c.Guid(nullable: false),
                        LeasingId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.CustomerSaves", "LeasingId", "dbo.Leasings");
            DropIndex("dbo.CustomerSaves", new[] { "LeasingId" });
            DropColumn("dbo.CustomerSaves", "LeasingId");
            CreateIndex("dbo.CustomerLeasings", "LeasingId");
            CreateIndex("dbo.CustomerLeasings", "CustomerId");
            AddForeignKey("dbo.CustomerLeasings", "LeasingId", "dbo.Leasings", "LeasingId", cascadeDelete: true);
            AddForeignKey("dbo.CustomerLeasings", "CustomerId", "dbo.CustomerSaves", "CustomerId", cascadeDelete: true);
        }
    }
}
