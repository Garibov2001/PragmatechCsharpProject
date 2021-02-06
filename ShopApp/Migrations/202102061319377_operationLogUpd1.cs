namespace ShopApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class operationLogUpd1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OperationLogs", "OperationDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OperationLogs", "OperationDescription");
        }
    }
}
