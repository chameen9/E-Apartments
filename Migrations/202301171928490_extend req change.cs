namespace E_Apartments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class extendreqchange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LeaseExtendRequests", "RequestedEndDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.LeaseExtendRequests", "RequestedEndDate");
        }
    }
}
