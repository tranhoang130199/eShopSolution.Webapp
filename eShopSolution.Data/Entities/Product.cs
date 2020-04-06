using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Product
    {
        //public string ProductAbbreviation { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int ViewCount { get; set; }

        public List<ProductInCategory> ProductInCategories { get; set; }
    }
}
