using FluentValidation;

namespace Modules.Customers
{
    public class AddDeliveryAddressRequest
    {
        public int CustomerId { get; set; }

        public string Address { get; set; }

        public bool IsDefault { get; set; }
    }

    public class AddDeliveryAddressResponse
    {
        public DeliveryAddressModel DeliveryAddress { get; set; }
    }

    public class AddDeliveryAddressRequestValidator : AbstractValidator<AddDeliveryAddressRequest>
    {
        public AddDeliveryAddressRequestValidator()
        {
            RuleFor(request => request.CustomerId).NotEmpty();
            RuleFor(request => request.Address).NotEmpty();
        }
    }
}
