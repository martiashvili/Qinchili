using FluentValidation;

namespace Modules.Customers
{
    public class UpdateDeliveryAddressRequest
    {
        public int CustomerId { get; set; }

        public int DeliveryAddressId { get; set; }

        public string Address { get; set; }

        public bool IsDefault { get; set; }
    }

    public class UpdateDeliveryAddressResponse
    {
        public DeliveryAddressModel DeliveryAddress { get; set; }
    }

    public class UpdateDeliveryAddressRequestValidator : AbstractValidator<UpdateDeliveryAddressRequest>
    {
        public UpdateDeliveryAddressRequestValidator()
        {
            RuleFor(request => request.CustomerId).NotEmpty();
            RuleFor(request => request.DeliveryAddressId).NotEmpty();
            RuleFor(request => request.Address).NotEmpty();
        }
    }
}
