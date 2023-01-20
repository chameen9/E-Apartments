namespace E_Apartments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcusleasings : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerLeasings",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CustomerId = c.Guid(nullable: false),
                        LeasingId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CustomerSaves", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Leasings", t => t.LeasingId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.LeasingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerLeasings", "LeasingId", "dbo.Leasings");
            DropForeignKey("dbo.CustomerLeasings", "CustomerId", "dbo.CustomerSaves");
            DropIndex("dbo.CustomerLeasings", new[] { "LeasingId" });
            DropIndex("dbo.CustomerLeasings", new[] { "CustomerId" });
            DropTable("dbo.CustomerLeasings");
        }
    }
}
