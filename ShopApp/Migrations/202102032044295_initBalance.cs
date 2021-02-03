namespace ShopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initBalance : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Balance", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Balance");
        }
    }
}
