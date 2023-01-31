using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Qinchili.Model;

namespace Qinchili.Db.Configurations
{
    public class ProductConfiguration : EntityConfiguration<Product>

    {
        public override void Map(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
        }
    }
}
