﻿namespace Qinchili.Domain
{
    public class Customer
    {
        public int CustomerId { get; set; }
        
        public string Firstname { get; set; }
        
        public string Lastname { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime Timestamp { get; set; }

        public ICollection<CustomerDeliveryAddress> CustomerDeliveryAddresses { get; set; }
    }
}