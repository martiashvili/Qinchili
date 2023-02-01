using FluentValidation;

namespace Modules.Products
{
    public class UpdateProductRequest
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string? Comment { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int CardsCount { get; set; }

        public long Price { get; set; }
    }

    public class UpdateProductResponse
    {
        public ProductModel Product { get; set; }
    }

    public class UpdateProductRequestValidator : AbstractValidator<UpdateProductRequest>
    {
        public UpdateProductRequestValidator()
        {
            RuleFor(request => request.ProductId).NotEmpty();
            RuleFor(request => request.Name).NotEmpty();
            RuleFor(request => request.Width).NotEmpty();
            RuleFor(request => request.Height).NotEmpty();
            RuleFor(request => request.CardsCount).NotEmpty();
            RuleFor(request => request.Price).NotEmpty();
        }
    }
}
