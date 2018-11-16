namespace CreateDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForProductForeignKeyCategoryAndForeignKeyManufacturer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Products", "Manufacturer_Id", "dbo.Manufacturers");
            DropIndex("dbo.Products", new[] { "Category_Id" });
            DropIndex("dbo.Products", new[] { "Manufacturer_Id" });
            RenameColumn(table: "dbo.Products", name: "Category_Id", newName: "CategoryId");
            RenameColumn(table: "dbo.Products", name: "Manufacturer_Id", newName: "ManufacturerId");
            AlterColumn("dbo.Products", "CategoryId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Products", "ManufacturerId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Products", "CategoryId");
            CreateIndex("dbo.Products", "ManufacturerId");
            AddForeignKey("dbo.Products", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Products", "ManufacturerId", "dbo.Manufacturers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ManufacturerId", "dbo.Manufacturers");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "ManufacturerId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            AlterColumn("dbo.Products", "ManufacturerId", c => c.Guid());
            AlterColumn("dbo.Products", "CategoryId", c => c.Guid());
            RenameColumn(table: "dbo.Products", name: "ManufacturerId", newName: "Manufacturer_Id");
            RenameColumn(table: "dbo.Products", name: "CategoryId", newName: "Category_Id");
            CreateIndex("dbo.Products", "Manufacturer_Id");
            CreateIndex("dbo.Products", "Category_Id");
            AddForeignKey("dbo.Products", "Manufacturer_Id", "dbo.Manufacturers", "Id");
            AddForeignKey("dbo.Products", "Category_Id", "dbo.Categories", "Id");
        }
    }
}
