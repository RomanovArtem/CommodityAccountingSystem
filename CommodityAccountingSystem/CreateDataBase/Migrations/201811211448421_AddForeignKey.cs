namespace CreateDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HistorySales", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.HistoryPrices", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Purchases", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Warehouses", "Product_Id", "dbo.Products");
            DropIndex("dbo.HistorySales", new[] { "Product_Id" });
            DropIndex("dbo.HistoryPrices", new[] { "Product_Id" });
            DropIndex("dbo.Purchases", new[] { "Product_Id" });
            DropIndex("dbo.Warehouses", new[] { "Product_Id" });
            RenameColumn(table: "dbo.HistorySales", name: "Product_Id", newName: "ProductId");
            RenameColumn(table: "dbo.HistoryPrices", name: "Product_Id", newName: "ProductId");
            RenameColumn(table: "dbo.Purchases", name: "Product_Id", newName: "ProductId");
            RenameColumn(table: "dbo.Warehouses", name: "Product_Id", newName: "ProductId");
            AlterColumn("dbo.HistorySales", "ProductId", c => c.Guid(nullable: false));
            AlterColumn("dbo.HistoryPrices", "ProductId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Purchases", "ProductId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Warehouses", "ProductId", c => c.Guid(nullable: false));
            CreateIndex("dbo.HistorySales", "ProductId");
            CreateIndex("dbo.HistoryPrices", "ProductId");
            CreateIndex("dbo.Purchases", "ProductId");
            CreateIndex("dbo.Warehouses", "ProductId");
            AddForeignKey("dbo.HistorySales", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.HistoryPrices", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Purchases", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Warehouses", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Warehouses", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Purchases", "ProductId", "dbo.Products");
            DropForeignKey("dbo.HistoryPrices", "ProductId", "dbo.Products");
            DropForeignKey("dbo.HistorySales", "ProductId", "dbo.Products");
            DropIndex("dbo.Warehouses", new[] { "ProductId" });
            DropIndex("dbo.Purchases", new[] { "ProductId" });
            DropIndex("dbo.HistoryPrices", new[] { "ProductId" });
            DropIndex("dbo.HistorySales", new[] { "ProductId" });
            AlterColumn("dbo.Warehouses", "ProductId", c => c.Guid());
            AlterColumn("dbo.Purchases", "ProductId", c => c.Guid());
            AlterColumn("dbo.HistoryPrices", "ProductId", c => c.Guid());
            AlterColumn("dbo.HistorySales", "ProductId", c => c.Guid());
            RenameColumn(table: "dbo.Warehouses", name: "ProductId", newName: "Product_Id");
            RenameColumn(table: "dbo.Purchases", name: "ProductId", newName: "Product_Id");
            RenameColumn(table: "dbo.HistoryPrices", name: "ProductId", newName: "Product_Id");
            RenameColumn(table: "dbo.HistorySales", name: "ProductId", newName: "Product_Id");
            CreateIndex("dbo.Warehouses", "Product_Id");
            CreateIndex("dbo.Purchases", "Product_Id");
            CreateIndex("dbo.HistoryPrices", "Product_Id");
            CreateIndex("dbo.HistorySales", "Product_Id");
            AddForeignKey("dbo.Warehouses", "Product_Id", "dbo.Products", "Id");
            AddForeignKey("dbo.Purchases", "Product_Id", "dbo.Products", "Id");
            AddForeignKey("dbo.HistoryPrices", "Product_Id", "dbo.Products", "Id");
            AddForeignKey("dbo.HistorySales", "Product_Id", "dbo.Products", "Id");
        }
    }
}
