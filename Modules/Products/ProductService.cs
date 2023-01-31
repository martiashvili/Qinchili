using Qinchili.Db;
using Qinchili.Model;

namespace Modules.Products
{
    public class ProductService : IProductService
    {
        public readonly IQinchiliContext db;

        public ProductService(IQinchiliContext db)
        {
            this.db = db;
        }

        public CreateProductResponse CreateProduct(CreateProductRequest request)
        {
            var product = new Product
            {
                Name = request.Name,
                Comment = request.Comment,
                Width = request.Width,
                Height = request.Height,
                CardsCount = request.CardsCount,
                Price = request.Price,
                TimeStamp = DateTime.Now
            };

            db.Products.Add(product);
            db.SaveChanges();

            return new CreateProductResponse
            {
                Product = new ProductModel
                {
                    ProductId = product.ProductId,
                    Name = product.Name,
                    Comment = product.Comment,
                    Width = product.Width,
                    Height = product.Height,
                    CardsCount = product.CardsCount,
                    Price = product.Price,
                    TimeStamp = product.TimeStamp
                }
            };
        }
    }
}