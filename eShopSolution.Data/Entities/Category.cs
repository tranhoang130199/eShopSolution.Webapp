using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int SortOrder { get; set; }
        public bool IsShowHome { get; set; }

        public List<ProductInCategory> ProductInCategories { get; set; }
    }
}
