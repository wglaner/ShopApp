using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShopApp.Models
{
    public class CartModel
    { 
     public int PurchaseID { get; set; }
     public int ProductID { get; set; }
     public int CustomerID { get; set; }
     [DisplayName("Data zamowienia")]
     public DateTime OrderDate { get; set; }

    }

    public class CartModelDBContext : DbContext
    {
        public DbSet<CartModel> CartModels { get; set; }
    }
}