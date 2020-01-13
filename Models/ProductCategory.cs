using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShopApp.Models
{
    public class ProductCategory
    {
        public int ProductCategoryID { get; set; }
        [DisplayName("Kategoria produktu")]
        public string CategoryName { get; set; }
    }
    public class ProductCategoryDBContext : DbContext
    {
        public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}