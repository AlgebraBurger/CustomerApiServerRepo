namespace CustomerApiServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class r2d2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "DateCreated");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "DateCreated", c => c.DateTime(nullable: false));
        }
    }
}
