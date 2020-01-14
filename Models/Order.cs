using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required(ErrorMessage= "Wprowadz imie")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwisko")]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Wprowadz ulice")]
        [StringLength(50)]
        public string Street { get; set; }
        [Required(ErrorMessage = "Wprowadz miasto")]
        [StringLength(50)]
        public string City { get; set; }
        [Required(ErrorMessage = "Wprowadz kod pocztowy")]
        [StringLength(6)]
        public string PostCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public decimal OrderValue { get; set; }

        List<OrderPosition> OrderPosition { get; set; }
    }

    public enum OrderStatus
    {
        New,
        Completed   
    }
}