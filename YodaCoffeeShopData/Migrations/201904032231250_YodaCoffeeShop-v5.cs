namespace YodaCoffeeShopData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YodaCoffeeShopv5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "SubTotal", c => c.Double(nullable: false));
            AddColumn("dbo.Orders", "ITBIS", c => c.Double(nullable: false));
            AddColumn("dbo.Orders", "Tip", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Tip");
            DropColumn("dbo.Orders", "ITBIS");
            DropColumn("dbo.Orders", "SubTotal");
        }
    }
}
