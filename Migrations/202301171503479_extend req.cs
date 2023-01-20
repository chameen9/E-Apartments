namespace E_Apartments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class extendreq : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LeaseExtendRequests",
                c => new
                    {
                        RequestId = c.Guid(nullable: false),
                        LeasingId = c.Guid(nullable: false),
                        Status = c.String(),
                        RequestedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RequestId)
                .ForeignKey("dbo.Leasings", t => t.LeasingId, cascadeDelete: true)
                .Index(t => t.LeasingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LeaseExtendRequests", "LeasingId", "dbo.Leasings");
            DropIndex("dbo.LeaseExtendRequests", new[] { "LeasingId" });
            DropTable("dbo.LeaseExtendRequests");
        }
    }
}
