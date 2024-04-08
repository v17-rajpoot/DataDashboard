namespace DataDashboard.Models
{
    public class Order
    {
        public int? OrderId { get; set; }
        public int? CustomerId { get; set; }

        public string? OrderDate { get; set; }
        
        public int? TotalAmount { get; set; }

    }
}