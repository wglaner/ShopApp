namespace ShopApp.Models
{
    public class OrderPosition
    {
        public int OrderPositionId { get; set; }
        public int OrderId { get; set; }

        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public int OrderPrice { get; set; }

        public virtual Product product { get; set; }
        public virtual Order order { get; set; }


    }
}