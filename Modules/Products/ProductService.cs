using Common;
using Microsoft.EntityFrameworkCore;
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

        public IResponse<CreateProductResponse> CreateProduct(CreateProductRequest request)
        {
            var existingProduct = db.Products.AsNoTracking().SingleOrDefault(p => p.Name == request.Name.Trim());
            if (existingProduct != null)
            {
                return ResponseHelper.Fail<CreateProductResponse>(StatusCode.ProductWithTheSameNameAlreadyExists);
            }

            var product = new Product
            {
                Name = request.Name.Trim(),
                Comment = request.Comment,
                Width = request.Width,
                Height = request.Height,
                CardsCount = request.CardsCount,
                Price = request.Price,
                TimeStamp = DateTime.Now
            };

            db.Products.Add(product);
            db.SaveChanges();

            return ResponseHelper.Ok(new CreateProductResponse
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
            });
        }
    }
}