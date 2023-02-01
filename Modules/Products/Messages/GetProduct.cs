using FluentValidation;

namespace Modules.Products
{
    public class GetProductRequest
    {
        public int ProductId { get; set; }
    }

    public class GetProductResponse
    {
        public ProductModel Product { get; set; }
    }

    public class GetProductRequestValidator : AbstractValidator<GetProductRequest>
    {
        public GetProductRequestValidator()
        {
            RuleFor(request => request.ProductId).NotEmpty();
        }
    }
}
