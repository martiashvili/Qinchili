using Microsoft.EntityFrameworkCore;

namespace Qinchili.Db.Configurations
{
    public interface IEntityConfiguration
    {
        void Map(ModelBuilder builder);
    }
}
