using Common;
using Common.Enums;
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
            var existingProduct = db.Products.AsNoTracking().SingleOrDefault(p => p.Name == request.Name.Trim() && p.DeleteTimeStamp != null);
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
                Product = CreateProductModel(product)
            });
        }

        public IResponse<EmptyResponse> DeleteProduct(DeleteProductRequest request)
        {
            var product = db.Products.SingleOrDefault(product => product.ProductId == request.ProductId && product.DeleteTimeStamp != null);
            if (product == null)
            {
                return ResponseHelper.Fail<EmptyResponse>(StatusCode.ProductNotFound);
            }

            product.DeleteTimeStamp = DateTime.Now;

            db.SaveChanges();

            return ResponseHelper.Ok();
        }

        public IResponse<GetProductResponse> GetProduct(GetProductRequest request)
        {
            var product = db.Products.AsNoTracking().SingleOrDefault(product => product.ProductId == request.ProductId && product.DeleteTimeStamp != null);
            if (product == null)
            {
                return ResponseHelper.Fail<GetProductResponse>(StatusCode.ProductNotFound);
            }

            return ResponseHelper.Ok(new GetProductResponse
            {
                Product = CreateProductModel(product)
            });
        }

        public IResponse<GetProductsResponse> GetProducts()
        {
            var products = db.Products.AsNoTracking().Where(product => product.DeleteTimeStamp != null).ToList();

            return ResponseHelper.Ok(new GetProductsResponse
            {
                Products = products.Select(product => CreateProductModel(product))
            });
        }

        public IResponse<UpdateProductResponse> UpdateProduct(UpdateProductRequest request)
        {
            var product = db.Products.SingleOrDefault(product => product.ProductId == request.ProductId && product.DeleteTimeStamp != null);
            if (product == null)
            {
                return ResponseHelper.Fail<UpdateProductResponse>(StatusCode.ProductNotFound);
            }

            if (db.Products.Any(product => product.ProductId != request.ProductId && product.Name == request.Name.Trim()))
            {
                return ResponseHelper.Fail<UpdateProductResponse>(StatusCode.ProductWithTheSameNameAlreadyExists);
            }

            product.Name = request.Name;
            product.Comment = request.Comment;
            product.Width = request.Width;
            product.Height = request.Height;
            product.Price = request.Price;
            product.CardsCount = request.CardsCount;

            db.SaveChanges();

            return ResponseHelper.Ok(new UpdateProductResponse { Product = CreateProductModel(product) });
        }

        private ProductModel CreateProductModel(Product product)
        {
            return new ProductModel
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Comment = product.Comment,
                Width = product.Width,
                Height = product.Height,
                CardsCount = product.CardsCount,
                Price = product.Price,
                TimeStamp = product.TimeStamp,
                DeleteTimeStamp = product.DeleteTimeStamp
            };
        }
    }
}