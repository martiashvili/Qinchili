using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Qinchili.Domain;

namespace Qinchili.Db.Configurations
{
    public class OrderItemConfiguration : EntityConfiguration<OrderItem>
    {
        public override void Map(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItems");

            builder.HasOne(orderItem => orderItem.Order).WithMany(order => order.OrderItems).HasForeignKey(orderItem => orderItem.OrderId).OnDelete(DeleteBehavior.NoAction); 
            builder.HasOne(orderItem => orderItem.Product).WithMany(product => product.OrderItems).HasForeignKey(orderItem => orderItem.ProductId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
