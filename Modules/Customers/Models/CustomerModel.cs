namespace Modules.Customers
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string PhoneNumber { get; set; }

        public string Comment { get; set; }

        public string FacebookUrl { get; set; }

        public DateTime Timestamp { get; set; }

        public List<DeliveryAddressModel> DeliveryAddresses { get; set; }
    }
}
