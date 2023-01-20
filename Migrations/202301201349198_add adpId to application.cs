namespace E_Apartments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addadpIdtoapplication : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AptApplications", "AdditionalParkingId", c => c.Int());
            AddColumn("dbo.AptApplications", "AdditionalParking_AddParkingId", c => c.Int());
            CreateIndex("dbo.AptApplications", "AdditionalParking_AddParkingId");
            AddForeignKey("dbo.AptApplications", "AdditionalParking_AddParkingId", "dbo.AdditionalParkings", "AddParkingId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AptApplications", "AdditionalParking_AddParkingId", "dbo.AdditionalParkings");
            DropIndex("dbo.AptApplications", new[] { "AdditionalParking_AddParkingId" });
            DropColumn("dbo.AptApplications", "AdditionalParking_AddParkingId");
            DropColumn("dbo.AptApplications", "AdditionalParkingId");
        }
    }
}
