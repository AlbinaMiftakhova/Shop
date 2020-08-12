namespace Shop.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ID_clothing { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual Clothing Clothing { get; set; }
        public virtual Order Order { get; set; }
    }
}