using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    public static class DataBase
    {
        private static ICollection<Product> products = new List<Product>
        {
            new Product { Id = Guid.Parse("70324a2e-190d-4a1b-a5bf-1d7b45839e92"), Title = "Томатный сок", PurchasePrice = 100,SalePrice = 120, Category = Categories.FirstOrDefault(c => c.Title == "Сок") },
            new Product { Id = Guid.Parse("54d3208d-8248-47ee-a43b-2270c92fa7c5"), Title = "Lays Краб", PurchasePrice = 80, SalePrice = 90, Category = Categories.FirstOrDefault(c => c.Title == "Чипсы")},
            new Product { Id = Guid.Parse("8450718c-970a-4d7f-b40f-11d413e1e438"), Title = "Nescafe кофе", PurchasePrice = 200, SalePrice = 250, Category = Categories.FirstOrDefault(c => c.Title == "Кофе")},
            new Product { Id = Guid.Parse("22e24b2e-caa6-4e87-b9a6-ff08ffa3c901"), Title = "Pringles сыр", PurchasePrice = 110, SalePrice = 140, Category = Categories.FirstOrDefault(c => c.Title == "Чипсы")},
            new Product { Id = Guid.Parse("0b6cb2dc-e8f9-41fd-9fe7-f4f56702dd79"), Title = "Jardin кофе", PurchasePrice = 250, SalePrice = 300, Category = Categories.FirstOrDefault(c => c.Title == "Кофе")},
            new Product { Id = Guid.Parse("ee4e487e-c391-4014-ad8f-fab74bb89baf"), Title = "Greenfield чай", PurchasePrice = 200, SalePrice = 250, Category = Categories.FirstOrDefault(c => c.Title == "Чай")},
            new Product { Id = Guid.Parse("c1da161b-7f85-4ddb-bd88-a01177ce778d"), Title = "Яблочный сок", PurchasePrice = 120, SalePrice = 140, Category = Categories.FirstOrDefault(c => c.Title == "Сок") },
            new Product { Id = Guid.Parse("ee4e487e-c391-4014-ad8f-fab74bb89baf"), Title = "Lipton чай", PurchasePrice = 180, SalePrice = 210, Category = Categories.FirstOrDefault(c => c.Title == "Чай")}
        };

        private static ICollection<Category> categories = new List<Category>
        {
            new Category { Id = Guid.Parse("5a565688-e804-48e7-84fa-31c93fc89f61"), Title = "Сок"},
            new Category { Id = Guid.Parse("44211b2c-7c66-4210-841f-cc33c97cc67e"), Title = "Кофе"},
            new Category { Id = Guid.Parse("a566f1d5-452b-43c0-863b-7d6e0200cfa9"), Title = "Чипсы"},
            new Category { Id = Guid.Parse("7a18fbe3-ca06-4a3a-88e1-cb051d40e33f"), Title = "Чай"}
        };

        public static ICollection<Product> Products { get { return products; } }
        public static ICollection<Category> Categories { get { return categories; } }

    }
}
