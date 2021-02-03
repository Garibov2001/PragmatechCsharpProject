namespace ShopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class purchaseInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PurchaseLogs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        PurchaseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: false)
                .Index(t => t.ProductID)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseLogs", "UserID", "dbo.Users");
            DropForeignKey("dbo.PurchaseLogs", "ProductID", "dbo.Products");
            DropIndex("dbo.PurchaseLogs", new[] { "UserID" });
            DropIndex("dbo.PurchaseLogs", new[] { "ProductID" });
            DropTable("dbo.PurchaseLogs");
        }
    }
}
