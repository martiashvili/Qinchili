using Microsoft.EntityFrameworkCore;
using Qinchili.Domain;
using Qinchili.Model;
using System.Reflection;

namespace Qinchili.Db
{
    public class QinchiliContext : DbContext, IQinchiliContext
    {
        public QinchiliContext(DbContextOptions options) 
            : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<CustomerDeliveryAddress> CustomerDeliveryAddresses { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.AddEntityConfigurations(GetType().GetTypeInfo().Assembly, nameof(QinchiliContext));
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
