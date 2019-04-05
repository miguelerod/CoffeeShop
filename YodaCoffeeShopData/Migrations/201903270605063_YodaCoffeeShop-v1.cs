namespace YodaCoffeeShopData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YodaCoffeeShopv1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Items", "Order_Id", "dbo.Orders");
            DropIndex("dbo.Items", new[] { "Order_Id" });
            CreateTable(
                "dbo.ReceiptTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderLines",
                c => new
                    {
                        OrderLineId = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        ItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderLineId)
                .ForeignKey("dbo.Items", t => t.ItemId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.ItemId);
            
            AddColumn("dbo.Clients", "ReceiptTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clients", "ReceiptTypeId");
            AddForeignKey("dbo.Clients", "ReceiptTypeId", "dbo.ReceiptTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.Items", "Order_Id");

            Sql(SqlStatements.makeReceiptTypes);
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Order_Id", c => c.Int());
            DropForeignKey("dbo.OrderLines", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderLines", "ItemId", "dbo.Items");
            DropForeignKey("dbo.Clients", "ReceiptTypeId", "dbo.ReceiptTypes");
            DropIndex("dbo.OrderLines", new[] { "ItemId" });
            DropIndex("dbo.OrderLines", new[] { "OrderId" });
            DropIndex("dbo.Clients", new[] { "ReceiptTypeId" });
            DropColumn("dbo.Clients", "ReceiptTypeId");
            DropTable("dbo.OrderLines");
            DropTable("dbo.ReceiptTypes");
            CreateIndex("dbo.Items", "Order_Id");
            AddForeignKey("dbo.Items", "Order_Id", "dbo.Orders", "Id");
        }
    }
}
