using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, SortOrder = 1, IsShowHome = true },
             new Category { Id = 2, SortOrder = 2, IsShowHome = false });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 1, Price = 10000, ViewCount = 1000});
            modelBuilder.Entity<ProductInCategory>().HasData(new ProductInCategory { ProductId = 1, CategoryId = 1 });
                         
        }
    }
}
