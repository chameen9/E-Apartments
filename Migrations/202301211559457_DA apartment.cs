namespace E_Apartments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DAapartment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Apartments", "DeletedAt", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Apartments", "DeletedAt");
        }
    }
}
