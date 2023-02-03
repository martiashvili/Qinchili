using Microsoft.EntityFrameworkCore;
using Qinchili.Domain;
using Qinchili.Model;

namespace Qinchili.Db
{
    public interface IQinchiliContext
    {
        DbSet<Product> Products { get; set; }
        
        DbSet<Customer> Customers { get; set; }

        DbSet<DeliveryAddress> CustomerDeliveryAddresses { get; set; }

        DbSet<Order> Orders { get; set; }

        DbSet<OrderItem> OrderItems { get; set; }

        int SaveChanges();
    }
}
