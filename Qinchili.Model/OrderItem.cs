using Qinchili.Model;

namespace Qinchili.Domain
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public long Price { get; set; }

        public DateTime Timestamp { get; set; }

        public DateTime? DeleteTimestamp { get; set; }
    }
}
