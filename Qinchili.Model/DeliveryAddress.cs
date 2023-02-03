namespace Qinchili.Domain
{
    public class DeliveryAddress
    {
        public int DeliveryAddressId { get; set; }

        public int? CustomerId { get; set; }

        public Customer Customer { get; set; }

        public bool IsDefault { get; set; }

        public string Address { get; set; }

        public DateTime Timestamp { get; set; }

        public DateTime? DeleteTimestamp { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
