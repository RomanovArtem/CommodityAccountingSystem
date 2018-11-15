namespace CreateDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    /// <summary>
    /// Создание новой схемы для таблиц
    /// </summary>
    public partial class CreateNewSchemaForTables : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "Categories", newSchema: "dbo");
            MoveTable(name: "Checks", newSchema: "dbo");
            MoveTable(name: "HistorySales", newSchema: "dbo");
            MoveTable(name: "Products", newSchema: "dbo");
            MoveTable(name: "Manufacturers", newSchema: "dbo");
            MoveTable(name: "HistoryPrices", newSchema: "dbo");
            MoveTable(name: "IncomeAndExpenses", newSchema: "dbo");
            MoveTable(name: "Messages", newSchema: "dbo");
            MoveTable(name: "Purchases", newSchema: "dbo");
            MoveTable(name: "Users", newSchema: "dbo");
            MoveTable(name: "Warehouses", newSchema: "dbo");
        }
        
        public override void Down()
        {
            MoveTable(name: "dbo.Warehouses", newSchema: null);
            MoveTable(name: "dbo.Users", newSchema: null);
            MoveTable(name: "dbo.Purchases", newSchema: null);
            MoveTable(name: "dbo.Messages", newSchema: null);
            MoveTable(name: "dbo.IncomeAndExpenses", newSchema: null);
            MoveTable(name: "dbo.HistoryPrices", newSchema: null);
            MoveTable(name: "dbo.Manufacturers", newSchema: null);
            MoveTable(name: "dbo.Products", newSchema: null);
            MoveTable(name: "dbo.HistorySales", newSchema: null);
            MoveTable(name: "dbo.Checks", newSchema: null);
            MoveTable(name: "dbo.Categories", newSchema: null);
        }
    }
}
