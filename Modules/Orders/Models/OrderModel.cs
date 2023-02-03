using Common.Enums;
using Modules.Customers;

namespace Modules.Orders
{
    public class OrderModel
    {
        public int OrderId { get; set; }

        public int? CustomerId { get; set; }

        public DeliveryAddressModel Address { get; set; }

        public string? CompleteDeliveryInfo { get; set; }

        public long? Discount { get; set; }

        public long? DeliveryPrice { get; set; }

        public long? OrderTotalPrice { get; set; }

        public bool IsPaid { get; set; }

        public string? Comment { get; set; }

        public OrderStatus Status { get; set; }

        public DateTime Timestamp { get; set; }

        public DateTime? SentTimestamp { get; set; }

        public List<OrderItemModel> Items { get; set; }
    }
}
