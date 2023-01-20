namespace E_Apartments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addadpIdtoapplication2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.AptApplications", name: "AdditionalParking_AddParkingId", newName: "AddParkingId");
            RenameIndex(table: "dbo.AptApplications", name: "IX_AdditionalParking_AddParkingId", newName: "IX_AddParkingId");
            DropColumn("dbo.AptApplications", "AdditionalParkingId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AptApplications", "AdditionalParkingId", c => c.Int());
            RenameIndex(table: "dbo.AptApplications", name: "IX_AddParkingId", newName: "IX_AdditionalParking_AddParkingId");
            RenameColumn(table: "dbo.AptApplications", name: "AddParkingId", newName: "AdditionalParking_AddParkingId");
        }
    }
}
