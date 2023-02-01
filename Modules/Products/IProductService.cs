using Common;

namespace Modules.Products
{
    public interface IProductService
    {
        public IResponse<CreateProductResponse> CreateProduct(CreateProductRequest request);

        public IResponse<UpdateProductResponse> UpdateProduct(UpdateProductRequest request);

        public IResponse<GetProductResponse> GetProduct(GetProductRequest request);

        public IResponse<GetProductsResponse> GetProducts();

        public IResponse<EmptyResponse> DeleteProduct(DeleteProductRequest request);
    }
}
