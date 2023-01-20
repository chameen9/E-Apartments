namespace E_Apartments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addadditonalparking3 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.AdditionalParkings", name: "Building_BuildingId", newName: "BuildingId");
            RenameIndex(table: "dbo.AdditionalParkings", name: "IX_Building_BuildingId", newName: "IX_BuildingId");
            DropColumn("dbo.AdditionalParkings", "AddBuildingId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AdditionalParkings", "AddBuildingId", c => c.String());
            RenameIndex(table: "dbo.AdditionalParkings", name: "IX_BuildingId", newName: "IX_Building_BuildingId");
            RenameColumn(table: "dbo.AdditionalParkings", name: "BuildingId", newName: "Building_BuildingId");
        }
    }
}
