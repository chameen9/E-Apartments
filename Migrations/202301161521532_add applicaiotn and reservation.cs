namespace E_Apartments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addapplicaiotnandreservation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AptApplications",
                c => new
                    {
                        AppID = c.Guid(nullable: false),
                        Status = c.String(nullable: false),
                        CustomerId = c.Guid(nullable: false),
                        ApartmentId = c.String(maxLength: 128),
                        CreatedAt = c.DateTime(nullable: false),
                        ResrvedFrom = c.DateTime(nullable: false),
                        ResrvedTo = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AppID)
                .ForeignKey("dbo.Apartments", t => t.ApartmentId)
                .ForeignKey("dbo.CustomerSaves", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.ApartmentId);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ResvId = c.Guid(nullable: false),
                        Status = c.String(nullable: false),
                        CustomerId = c.Guid(nullable: false),
                        ApartmentId = c.String(maxLength: 128),
                        CreatedAt = c.DateTime(nullable: false),
                        ResrvedFrom = c.DateTime(nullable: false),
                        ResrvedTo = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ResvId)
                .ForeignKey("dbo.Apartments", t => t.ApartmentId)
                .ForeignKey("dbo.CustomerSaves", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.ApartmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "CustomerId", "dbo.CustomerSaves");
            DropForeignKey("dbo.Reservations", "ApartmentId", "dbo.Apartments");
            DropForeignKey("dbo.AptApplications", "CustomerId", "dbo.CustomerSaves");
            DropForeignKey("dbo.AptApplications", "ApartmentId", "dbo.Apartments");
            DropIndex("dbo.Reservations", new[] { "ApartmentId" });
            DropIndex("dbo.Reservations", new[] { "CustomerId" });
            DropIndex("dbo.AptApplications", new[] { "ApartmentId" });
            DropIndex("dbo.AptApplications", new[] { "CustomerId" });
            DropTable("dbo.Reservations");
            DropTable("dbo.AptApplications");
        }
    }
}
