using FluentValidation;

namespace Modules.Customers
{
    public class DeleteDeliveryAddressRequest
    {
        public int CustomerId { get; set; }

        public int DeliveryAddressId { get; set; }
    }

    public class DeleteDeliveryAddressRequestValidator : AbstractValidator<DeleteDeliveryAddressRequest>
    {
        public DeleteDeliveryAddressRequestValidator()
        {
            RuleFor(request => request.CustomerId).NotEmpty();
            RuleFor(request => request.DeliveryAddressId).NotEmpty();
        }
    }
}
