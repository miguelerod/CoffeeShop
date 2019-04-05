namespace YodaCoffeeShopData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YodaCoffeev4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "OrderNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "OrderNumber");
        }
    }
}
