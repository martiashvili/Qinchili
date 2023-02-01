using Common.Enums;

namespace Qinchili.Domain
{
    public class Order
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; } 

        public int DeiveryAddressId { get; set; }

        public CustomerDeliveryAddress Address { get; set; }

        public string CompleteDeliveryInfo { get; set; }

        public long Discount { get; set; }

        public long DeliveryPrice { get; set; }

        public bool IsPaid { get; set; }

        public string Comment { get; set; }

        public OrderStatus Status { get; set; }

        public DateTime Timestamp { get; set; }

        public DateTime? SentTimestamp { get; set; }
        
        public DateTime? DeliveredTimestamp { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
