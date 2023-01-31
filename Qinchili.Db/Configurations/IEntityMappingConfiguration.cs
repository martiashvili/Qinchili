using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Qinchili.Db.Configurations
{
    public interface IEntityMappingConfiguration<T> : IEntityConfiguration
        where T : class
    {
        void Map(EntityTypeBuilder<T> builder);
    }
}
