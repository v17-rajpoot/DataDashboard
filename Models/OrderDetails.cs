namespace DataDashboard.Models
{
    public class OrderDetails{
        public int? OrderDetailId { get; set; }
        public int? OrderId { get; set; }

        public int? ProductId { get; set; }

        public int Quantity { get; set; }

        public int UnitPrice { get; set; }
    }
}