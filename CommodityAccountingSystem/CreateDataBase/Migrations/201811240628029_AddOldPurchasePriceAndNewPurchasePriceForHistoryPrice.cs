namespace CreateDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOldPurchasePriceAndNewPurchasePriceForHistoryPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HistoryPrices", "OldSalePrice", c => c.Double(nullable: false));
            AddColumn("dbo.HistoryPrices", "NewSalePrice", c => c.Double(nullable: false));
            AddColumn("dbo.HistoryPrices", "OldPurchasePrice", c => c.Double(nullable: false));
            AddColumn("dbo.HistoryPrices", "NewPurchasePrice", c => c.Double(nullable: false));
            DropColumn("dbo.HistoryPrices", "OldPrice");
            DropColumn("dbo.HistoryPrices", "NewPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HistoryPrices", "NewPrice", c => c.Double(nullable: false));
            AddColumn("dbo.HistoryPrices", "OldPrice", c => c.Double(nullable: false));
            DropColumn("dbo.HistoryPrices", "NewPurchasePrice");
            DropColumn("dbo.HistoryPrices", "OldPurchasePrice");
            DropColumn("dbo.HistoryPrices", "NewSalePrice");
            DropColumn("dbo.HistoryPrices", "OldSalePrice");
        }
    }
}
