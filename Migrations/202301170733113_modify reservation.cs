namespace E_Apartments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyreservation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "AdditionalParkingFee", c => c.Double());
            AddColumn("dbo.Reservations", "RefundableAmount", c => c.Double());
            AddColumn("dbo.Reservations", "MonthlyRate", c => c.Double());
            AddColumn("dbo.Reservations", "TotalAmount", c => c.Double());
            AddColumn("dbo.Reservations", "PaidAmount", c => c.Double());
            AddColumn("dbo.Reservations", "Balance", c => c.Double());
            AddColumn("dbo.Reservations", "ClassID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Reservations", "ClassID");
            AddForeignKey("dbo.Reservations", "ClassID", "dbo.Classes", "ClassId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "ClassID", "dbo.Classes");
            DropIndex("dbo.Reservations", new[] { "ClassID" });
            DropColumn("dbo.Reservations", "ClassID");
            DropColumn("dbo.Reservations", "Balance");
            DropColumn("dbo.Reservations", "PaidAmount");
            DropColumn("dbo.Reservations", "TotalAmount");
            DropColumn("dbo.Reservations", "MonthlyRate");
            DropColumn("dbo.Reservations", "RefundableAmount");
            DropColumn("dbo.Reservations", "AdditionalParkingFee");
        }
    }
}
