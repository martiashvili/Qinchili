using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Qinchili.Domain;

namespace Qinchili.Db.Configurations
{
    public class OrderConfiguration : EntityConfiguration<Order>
    {
        public override void Map(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");

            builder.HasOne(order => order.Customer).WithMany(customer => customer.Orders).HasForeignKey(order => order.CustomerId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(order => order.Address).WithMany(address => address.Orders).HasForeignKey(order => order.DeliveryAddressId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
