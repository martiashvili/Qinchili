namespace Qinchili.Domain
{
    public class CustomerDeliveryAddress
    {
        public int CustomerDeliveryAddressId { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public string Address { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
