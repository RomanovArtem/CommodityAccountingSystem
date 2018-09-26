using CommodityAccountingSystem.Model;
using System;
using System.Collections.Generic;

namespace Repositories
{
    public static class DataBase
    {
        private static ICollection<Product> products = new List<Product>
        {
            new Product {Id = Guid.Parse("70324a2e-190d-4a1b-a5bf-1d7b45839e92"), Title="Томатный сок", PurchasePrice=100,SalePrice = 120 },
            new Product {Id = Guid.Parse("54d3208d-8248-47ee-a43b-2270c92fa7c5"), Title="Чипсы", PurchasePrice=80, SalePrice = 90 }
        };

        public static ICollection<Product> Products { get { return products; } }

    }
}
