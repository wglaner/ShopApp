using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopApp.Models
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }

        [Required(ErrorMessage= "Wprowadz nazwe kategorii")]
        [StringLength(100)]
        public string ProductCategoryName { get; set; }
        [Required(ErrorMessage = "Wprowadz opis kategorii")]
        public string ProductCategoryDescription { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}