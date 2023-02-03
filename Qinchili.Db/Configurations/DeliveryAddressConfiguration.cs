using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Qinchili.Domain;

namespace Qinchili.Db.Configurations
{
    public class DeliveryAddressConfiguration : EntityConfiguration<DeliveryAddress>
    {
        public override void Map(EntityTypeBuilder<DeliveryAddress> builder)
        {
            builder.ToTable("DeliveryAddresses");

            builder.Property(prop => prop.Address).IsRequired();
            builder.HasOne(address => address.Customer).WithMany(customer => customer.CustomerDeliveryAddresses).HasForeignKey(address => address.CustomerId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
