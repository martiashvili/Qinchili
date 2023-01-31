namespace Modules.Products
{
    public interface IProductService
    {
        public CreateProductResponse CreateProduct(CreateProductRequest request);
    }
}
