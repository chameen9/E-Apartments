namespace E_Apartments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addadditonalparking : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdditionalParkings",
                c => new
                    {
                        AddParkingId = c.Int(nullable: false, identity: true),
                        AddStatus = c.String(nullable: false),
                        AddBuildingId = c.String(),
                        Building_BuildingId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.AddParkingId)
                .ForeignKey("dbo.Buildings", t => t.Building_BuildingId)
                .Index(t => t.Building_BuildingId);
            
            AddColumn("dbo.Apartments", "AddParkingId", c => c.Int());
            CreateIndex("dbo.Apartments", "AddParkingId");
            AddForeignKey("dbo.Apartments", "AddParkingId", "dbo.AdditionalParkings", "AddParkingId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AdditionalParkings", "Building_BuildingId", "dbo.Buildings");
            DropForeignKey("dbo.Apartments", "AddParkingId", "dbo.AdditionalParkings");
            DropIndex("dbo.AdditionalParkings", new[] { "Building_BuildingId" });
            DropIndex("dbo.Apartments", new[] { "AddParkingId" });
            DropColumn("dbo.Apartments", "AddParkingId");
            DropTable("dbo.AdditionalParkings");
        }
    }
}
