namespace YodaCoffeeShopData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YodaCoffeeShopv2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReceiptTypes", "Type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ReceiptTypes", "Type");
        }
    }
}
