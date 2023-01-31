using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Qinchili.Domain;

namespace Qinchili.Db.Configurations
{
    public class CustomerConfiguration : EntityConfiguration<Customer>
    {
        public override void Map(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            builder.Property(prop => prop.Firstname).IsRequired();
            builder.Property(prop => prop.Lastname).IsRequired();
        }
    }
}
