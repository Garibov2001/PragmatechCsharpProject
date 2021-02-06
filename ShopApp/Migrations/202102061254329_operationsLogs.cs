namespace ShopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class operationsLogs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OperationLogs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OperationStatus = c.Int(nullable: false),
                        OperationDate = c.DateTime(nullable: false),
                        ProductID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: false)
                .Index(t => t.ProductID)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OperationLogs", "UserID", "dbo.Users");
            DropForeignKey("dbo.OperationLogs", "ProductID", "dbo.Products");
            DropIndex("dbo.OperationLogs", new[] { "UserID" });
            DropIndex("dbo.OperationLogs", new[] { "ProductID" });
            DropTable("dbo.OperationLogs");
        }
    }
}
