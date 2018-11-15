using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public static class DataBase
    {
        private static ICollection<Category> categories = new List<Category>
        {
            new Category { Id = Guid.Parse("5a565688-e804-48e7-84fa-31c93fc89f61"), Title = "Сок"},
            new Category { Id = Guid.Parse("44211b2c-7c66-4210-841f-cc33c97cc67e"), Title = "Кофе"},
            new Category { Id = Guid.Parse("a566f1d5-452b-43c0-863b-7d6e0200cfa9"), Title = "Чипсы"},
            new Category { Id = Guid.Parse("7a18fbe3-ca06-4a3a-88e1-cb051d40e33f"), Title = "Чай"}
        };

        private static ICollection<Manufacturer> manufacturers = new List<Manufacturer>
        {
            new Manufacturer { Id = Guid.Parse("4255aa1a-722c-4d52-93b2-945195e6c881"), Title = "Lays"},
            new Manufacturer { Id = Guid.Parse("49b0cd3e-0cea-4bfc-b797-eb7553565e70"), Title = "J7"},
            new Manufacturer { Id = Guid.Parse("3fe01296-9ea3-45d1-bb20-13150ab86e01"), Title = "Jardin"},
            new Manufacturer { Id = Guid.Parse("0b8f1f4f-f323-460e-8349-9133f513d03d"), Title = "Pringles"},
            new Manufacturer { Id = Guid.Parse("219d5edb-9ffd-47e2-990b-ee52f1a658df"), Title = "Greenfield"},
            new Manufacturer { Id = Guid.Parse("520a124d-2f42-487e-a7c1-a7b387b7d07b"), Title = "Добрый"},
            new Manufacturer { Id = Guid.Parse("45a832c5-7b48-4fcc-a5b0-feac40697b41"), Title = "Nescafe"},
            new Manufacturer { Id = Guid.Parse("45a832c5-7b48-4fcc-a5b0-feac40697b41"), Title = "Lipton"}
        };

        private static ICollection<Product> products = new List<Product>
        {
            new Product { Id = Guid.Parse("70324a2e-190d-4a1b-a5bf-1d7b45839e92"), Title = "Томатный сок", PurchasePrice = 100,SalePrice = 120, Category = Categories.FirstOrDefault(c => c.Title == "Сок"), Manufacturer = Manufacturers.FirstOrDefault(m=>m.Title == "J7")},
            new Product { Id = Guid.Parse("54d3208d-8248-47ee-a43b-2270c92fa7c5"), Title = "Lays краб", PurchasePrice = 80, SalePrice = 90, Category = Categories.FirstOrDefault(c => c.Title == "Чипсы"), Manufacturer = Manufacturers.FirstOrDefault(m=>m.Title == "Lays")},
            new Product { Id = Guid.Parse("8450718c-970a-4d7f-b40f-11d413e1e438"), Title = "Nescafe кофе", PurchasePrice = 200, SalePrice = 250, Category = Categories.FirstOrDefault(c => c.Title == "Кофе"), Manufacturer = Manufacturers.FirstOrDefault(m=>m.Title == "Nescafe")},
            new Product { Id = Guid.Parse("22e24b2e-caa6-4e87-b9a6-ff08ffa3c901"), Title = "Pringles сыр", PurchasePrice = 110, SalePrice = 140, Category = Categories.FirstOrDefault(c => c.Title == "Чипсы"), Manufacturer = Manufacturers.FirstOrDefault(m=>m.Title == "Pringles")},
            new Product { Id = Guid.Parse("0b6cb2dc-e8f9-41fd-9fe7-f4f56702dd79"), Title = "Jardin кофе", PurchasePrice = 250, SalePrice = 300, Category = Categories.FirstOrDefault(c => c.Title == "Кофе"), Manufacturer = Manufacturers.FirstOrDefault(m=>m.Title == "Jardin")},
            new Product { Id = Guid.Parse("ee4e487e-c391-4014-ad8f-fab74bb89baf"), Title = "Greenfield чай", PurchasePrice = 200, SalePrice = 250, Category = Categories.FirstOrDefault(c => c.Title == "Чай"), Manufacturer = Manufacturers.FirstOrDefault(m=>m.Title == "Greenfield")},
            new Product { Id = Guid.Parse("c1da161b-7f85-4ddb-bd88-a01177ce778d"), Title = "Яблочный сок", PurchasePrice = 120, SalePrice = 140, Category = Categories.FirstOrDefault(c => c.Title == "Сок"), Manufacturer = Manufacturers.FirstOrDefault(m=>m.Title == "Добрый")},
            new Product { Id = Guid.Parse("ee4e487e-c391-4014-ad8f-fab74bb89baf"), Title = "Lipton чай", PurchasePrice = 180, SalePrice = 210, Category = Categories.FirstOrDefault(c => c.Title == "Чай"), Manufacturer = Manufacturers.FirstOrDefault(m=>m.Title == "Lipton")}
        };

        private static ICollection<HistorySales> historySales = new List<HistorySales>
        {
            new HistorySales { Id = Guid.NewGuid(), Product = Products.FirstOrDefault(p => p.Title == "Томатный сок"), Count = 2, Amount = Products.FirstOrDefault(p => p.Title == "Томатный сок").SalePrice * 2, Date = DateTime.MinValue},
            new HistorySales { Id = Guid.NewGuid(), Product = Products.FirstOrDefault(p => p.Title == "Greenfield чай"), Count = 4, Amount = Products.FirstOrDefault(p => p.Title == "Greenfield чай").SalePrice * 4, Date = DateTime.MaxValue}
        };

        private static ICollection<User> users = new List<User>
        {
            new User { Id = Guid.NewGuid(), Login="admin", Password="123"}
        };

        public static ICollection<Product> Products         { get { return products; } }

        public static ICollection<Category> Categories          { get { return categories; } }

        public static ICollection<Manufacturer> Manufacturers   { get { return manufacturers; } }

        public static ICollection<HistorySales> HistorySales    { get { return historySales; } }

        public static ICollection<User> Users                   { get { return users; } }
    }
}
