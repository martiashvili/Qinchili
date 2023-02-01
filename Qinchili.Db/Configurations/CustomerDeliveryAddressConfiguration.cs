using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Qinchili.Domain;

namespace Qinchili.Db.Configurations
{
    public class CustomerDeliveryAddressConfiguration : EntityConfiguration<CustomerDeliveryAddress>
    {
        public override void Map(EntityTypeBuilder<CustomerDeliveryAddress> builder)
        {
            builder.ToTable("CustomerDeliveryAddresses");

            builder.Property(prop => prop.Address).IsRequired();
            builder.HasOne(address => address.Customer).WithMany(customer => customer.CustomerDeliveryAddresses).HasForeignKey(address => address.CustomerId).OnDelete(DeleteBehavior.NoAction); ;
        }
    }
}
