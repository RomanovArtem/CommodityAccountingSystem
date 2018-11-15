namespace CreateDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Categories",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Checks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Number = c.Int(nullable: false),
                        DateSale = c.DateTime(nullable: false),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "HistorySales",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Count = c.Int(nullable: false),
                        Amount = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Product_Id = c.Guid(),
                        Check_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Products", t => t.Product_Id)
                .ForeignKey("Checks", t => t.Check_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Check_Id);
            
            CreateTable(
                "Products",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                        PurchasePrice = c.Double(nullable: false),
                        SalePrice = c.Double(nullable: false),
                        Category_Id = c.Guid(),
                        Manufacturer_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Categories", t => t.Category_Id)
                .ForeignKey("Manufacturers", t => t.Manufacturer_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.Manufacturer_Id);
            
            CreateTable(
                "Manufacturers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "HistoryPrices",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        OldPrice = c.Double(nullable: false),
                        NewPrice = c.Double(nullable: false),
                        InstallationDateNewPrice = c.DateTime(nullable: false),
                        Product_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Products", t => t.Product_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "IncomeAndExpenses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Expense = c.Double(nullable: false),
                        Income = c.Double(nullable: false),
                        Rent = c.Double(nullable: false),
                        Salary = c.Double(nullable: false),
                        Delivery = c.Double(nullable: false),
                        UnforeseenExpenses = c.Double(nullable: false),
                        Comment = c.String(),
                        BeginPeriod = c.DateTime(nullable: false),
                        EndPeriod = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Messages",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Purchases",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DatePurchase = c.DateTime(nullable: false),
                        PurchasePrice = c.Double(nullable: false),
                        Count = c.Int(nullable: false),
                        Amount = c.Double(nullable: false),
                        Product_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Products", t => t.Product_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Warehouses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Count = c.Int(nullable: false),
                        Product_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Products", t => t.Product_Id)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Warehouses", "Product_Id", "Products");
            DropForeignKey("Purchases", "Product_Id", "Products");
            DropForeignKey("HistoryPrices", "Product_Id", "Products");
            DropForeignKey("HistorySales", "Check_Id", "Checks");
            DropForeignKey("HistorySales", "Product_Id", "Products");
            DropForeignKey("Products", "Manufacturer_Id", "Manufacturers");
            DropForeignKey("Products", "Category_Id", "Categories");
            DropIndex("Warehouses", new[] { "Product_Id" });
            DropIndex("Purchases", new[] { "Product_Id" });
            DropIndex("HistoryPrices", new[] { "Product_Id" });
            DropIndex("Products", new[] { "Manufacturer_Id" });
            DropIndex("Products", new[] { "Category_Id" });
            DropIndex("HistorySales", new[] { "Check_Id" });
            DropIndex("HistorySales", new[] { "Product_Id" });
            DropTable("Warehouses");
            DropTable("Users");
            DropTable("Purchases");
            DropTable("Messages");
            DropTable("IncomeAndExpenses");
            DropTable("HistoryPrices");
            DropTable("Manufacturers");
            DropTable("Products");
            DropTable("HistorySales");
            DropTable("Checks");
            DropTable("Categories");
        }
    }
}
