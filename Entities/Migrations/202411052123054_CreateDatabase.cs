namespace Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "ProductName", c => c.String());
            AddColumn("dbo.Product", "Description", c => c.String());
            DropColumn("dbo.Product", "ProductDescription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Product", "ProductDescription", c => c.String());
            DropColumn("dbo.Product", "Description");
            DropColumn("dbo.Product", "ProductName");
        }
    }
}
