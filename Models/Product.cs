using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Web;



namespace ShopApp.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [DisplayName("Nazwa")]
        public string ProductName { get; set; }
        [DisplayName("Kod kreskowy EAN")]
        public string EAN { get; set; }
        [DisplayName("Cena jednostkowa")]
        public double Price { get; set; }
        [DisplayName("Jednostka")]
        public string Unit { get; set; }
        [DisplayName("Stan magazynowy")]
        public int Availability { get; set; }

    }

    public class ProductDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}