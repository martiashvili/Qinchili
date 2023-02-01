using FluentValidation;

namespace Modules.Customers
{
    public class MakeDeliveryAddressDefaultRequest
    {
        public int CustomerId { get; set; }

        public int DeliveryAddressId { get; set; }

        public bool IsDefault { get; set; }
    }

    public class MakeDeliveryAddressDefaultResponse
    {
        public DeliveryAddressModel DeliveryAddress { get; set; }
    }

    public class MakeDeliveryAddressDefaultRequestValidator : AbstractValidator<MakeDeliveryAddressDefaultRequest>
    {
        public MakeDeliveryAddressDefaultRequestValidator()
        {
            RuleFor(request => request.CustomerId).NotEmpty();
            RuleFor(request => request.DeliveryAddressId).NotEmpty();
        }
    }
}
