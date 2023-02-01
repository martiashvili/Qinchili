using FluentValidation;

namespace Modules.Products
{
    public class DeleteProductRequest
    {
        public int ProductId { get; set; }
    }

    public class DeleteProductRequestValidator : AbstractValidator<DeleteProductRequest>
    {
        public DeleteProductRequestValidator()
        {
            RuleFor(request => request.ProductId).NotEmpty();
        }
    }
}
