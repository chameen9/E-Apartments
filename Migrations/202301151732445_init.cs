namespace E_Apartments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Apartments",
                c => new
                    {
                        ApartmentId = c.String(nullable: false, maxLength: 128),
                        FloorNumber = c.Int(nullable: false),
                        BuildingId = c.String(maxLength: 128),
                        CustomerId = c.Guid(),
                        ParkingId = c.String(maxLength: 128),
                        ClassId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ApartmentId)
                .ForeignKey("dbo.Buildings", t => t.BuildingId)
                .ForeignKey("dbo.Parkings", t => t.ParkingId)
                .ForeignKey("dbo.Classes", t => t.ClassId)
                .ForeignKey("dbo.CustomerSaves", t => t.CustomerId)
                .Index(t => t.BuildingId)
                .Index(t => t.CustomerId)
                .Index(t => t.ParkingId)
                .Index(t => t.ClassId);
            
            CreateTable(
                "dbo.Buildings",
                c => new
                    {
                        BuildingId = c.String(nullable: false, maxLength: 128),
                        BuildingName = c.String(nullable: false),
                        Location = c.String(nullable: false),
                        ApartmentsCount = c.Int(nullable: false),
                        ParkingsCount = c.Int(nullable: false),
                        AdditionalParkingsCount = c.Int(nullable: false),
                        FLoorCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BuildingId);
            
            CreateTable(
                "dbo.Parkings",
                c => new
                    {
                        ParkingId = c.String(nullable: false, maxLength: 128),
                        Status = c.String(nullable: false),
                        BuildingId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ParkingId)
                .ForeignKey("dbo.Buildings", t => t.BuildingId)
                .Index(t => t.BuildingId);
            
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ClassId = c.String(nullable: false, maxLength: 128),
                        ClassName = c.String(nullable: false),
                        RefundableAmount = c.Double(nullable: false),
                        NonRefundableReservationAmount = c.Double(nullable: false),
                        MonthlyRate = c.Double(nullable: false),
                        RoomsWithAttachedBathroomsCount = c.Int(nullable: false),
                        CommonBathroomsCount = c.Int(nullable: false),
                        CommonRoomsCount = c.Int(nullable: false),
                        ServentBathroomsCount = c.Int(nullable: false),
                        ServentRoomsCount = c.Int(nullable: false),
                        MaxOccuepentsCount = c.Int(nullable: false),
                        AdditionalParkingFee = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ClassId);
            
            CreateTable(
                "dbo.Leasings",
                c => new
                    {
                        LeasingId = c.Guid(nullable: false),
                        ApartmentID = c.String(nullable: false),
                        StartedDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        AdditionalParkingFee = c.Double(),
                        RefundableAmount = c.Double(nullable: false),
                        MonthlyRate = c.Double(nullable: false),
                        TotalAmount = c.Double(nullable: false),
                        PaidAmount = c.Double(nullable: false),
                        Balance = c.Double(nullable: false),
                        ClassID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.LeasingId)
                .ForeignKey("dbo.Classes", t => t.ClassID)
                .Index(t => t.ClassID);
            
            CreateTable(
                "dbo.CustomerSaves",
                c => new
                    {
                        CustomerId = c.Guid(nullable: false),
                        CustomerName = c.String(nullable: false),
                        CustomerEmail = c.String(nullable: false),
                        CustomerPhone = c.String(nullable: false),
                        CustomerAge = c.Int(nullable: false),
                        CustomerAddress = c.String(nullable: false),
                        NICPassport = c.String(nullable: false),
                        LeasingId = c.Guid(),
                        UserId = c.Guid(),
                        CreatedAt = c.DateTime(),
                        UpdatedAt = c.DateTime(nullable: false),
                        ReferenceNumber = c.String(nullable: false),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.Leasings", t => t.LeasingId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.LeasingId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Dependents",
                c => new
                    {
                        DependentId = c.Guid(nullable: false),
                        DependentName = c.String(nullable: false),
                        Relationship = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        CustomerId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.DependentId)
                .ForeignKey("dbo.CustomerSaves", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        Email = c.String(nullable: false),
                        Username = c.String(),
                        Password = c.String(nullable: false),
                        UserType = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerSaves", "UserId", "dbo.Users");
            DropForeignKey("dbo.CustomerSaves", "LeasingId", "dbo.Leasings");
            DropForeignKey("dbo.Dependents", "CustomerId", "dbo.CustomerSaves");
            DropForeignKey("dbo.Apartments", "CustomerId", "dbo.CustomerSaves");
            DropForeignKey("dbo.Leasings", "ClassID", "dbo.Classes");
            DropForeignKey("dbo.Apartments", "ClassId", "dbo.Classes");
            DropForeignKey("dbo.Parkings", "BuildingId", "dbo.Buildings");
            DropForeignKey("dbo.Apartments", "ParkingId", "dbo.Parkings");
            DropForeignKey("dbo.Apartments", "BuildingId", "dbo.Buildings");
            DropIndex("dbo.Dependents", new[] { "CustomerId" });
            DropIndex("dbo.CustomerSaves", new[] { "UserId" });
            DropIndex("dbo.CustomerSaves", new[] { "LeasingId" });
            DropIndex("dbo.Leasings", new[] { "ClassID" });
            DropIndex("dbo.Parkings", new[] { "BuildingId" });
            DropIndex("dbo.Apartments", new[] { "ClassId" });
            DropIndex("dbo.Apartments", new[] { "ParkingId" });
            DropIndex("dbo.Apartments", new[] { "CustomerId" });
            DropIndex("dbo.Apartments", new[] { "BuildingId" });
            DropTable("dbo.Users");
            DropTable("dbo.Dependents");
            DropTable("dbo.CustomerSaves");
            DropTable("dbo.Leasings");
            DropTable("dbo.Classes");
            DropTable("dbo.Parkings");
            DropTable("dbo.Buildings");
            DropTable("dbo.Apartments");
        }
    }
}
