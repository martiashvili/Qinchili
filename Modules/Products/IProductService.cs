using Common;

namespace Modules.Products
{
    public interface IProductService
    {
        public IResponse<CreateProductResponse> CreateProduct(CreateProductRequest request);
    }
}
