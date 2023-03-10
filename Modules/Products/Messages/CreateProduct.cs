using FluentValidation;

namespace Modules.Products
{
    public class CreateProductRequest
    {
        public string Name { get; set; }

        public string? Comment { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int CardsCount { get; set; }

        public long Price { get; set; }
    }

    public class CreateProductResponse
    {
        public ProductModel Product { get; set; }
    }

    public class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
    {
        public CreateProductRequestValidator()
        {
            RuleFor(request => request.Name).NotEmpty();
            RuleFor(request => request.Width).NotEmpty();
            RuleFor(request => request.Height).NotEmpty();
            RuleFor(request => request.CardsCount).NotEmpty();
            RuleFor(request => request.Price).NotEmpty();
        }
    }
}
