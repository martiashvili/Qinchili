namespace Modules.Customers
{
    public class DeliveryAddressModel
    {
        public int CustomerDeliveryAddressId { get; set; }

        public int? CustomerId { get; set; }

        public string Address { get; set; }

        public bool IsDefault { get; set; }

        public DateTime Timestamp { get; set; }

        public DateTime? DeleteTimestamp { get; set; }
    }
}
