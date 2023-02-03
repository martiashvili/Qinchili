using FluentValidation;

namespace Modules.Orders
{
    public class CreateOrderRequest
    {
        public int CustomerId { get; set; }

        public int? DeliverAddressId { get; set; }

        public long? Discount { get; set; }

        public long? DeliveryPrice { get; set; }

        public string? Comment { get; set; }

        public List<int> ProductIds { get; set; }
    }

    public class CreateOrderResponse
    {
        public OrderModel Order { get; set; }
    }

    public class CreateOrderRequestValidator : AbstractValidator<CreateOrderRequest>
    {
        public CreateOrderRequestValidator()
        {
            RuleFor(request => request.CustomerId).NotEmpty();
        }
    }
}
