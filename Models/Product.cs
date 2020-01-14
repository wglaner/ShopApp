using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;



namespace ShopApp.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwe produktu")]
        [DisplayName("Nazwa")]
        [StringLength(50)]
        public string ProductName { get; set; }
        [DisplayName("Kod kreskowy EAN")]
        public int ProductCategoryId { get; set; }
        [Required(ErrorMessage = "Wprowadz kod kreskowy EAN")]
        public string EAN { get; set; }
        [DisplayName("Cena jednostkowa")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Podaj typ")]
        [DisplayName("Jednostka")]
        public Unit Unit { get; set; }
        [DisplayName("Stan magazynowy")]
        public bool Availability { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
    }
    public enum Unit
    {
        kg,
        szt,
        litr
    }

}