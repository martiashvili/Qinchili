using Qinchili.Db;

namespace Modules.Products
{
    public class ProductService : IProductService
    {
        public readonly IQinchiliContext Db;

        public ProductService(IQinchiliContext Db)
        {
            this.Db = Db;
        }

        public IEnumerable<int> GetProduct()
        {
            throw new NotImplementedException();
        }
    }
}