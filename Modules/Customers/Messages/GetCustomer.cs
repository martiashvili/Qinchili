using FluentValidation;

namespace Modules.Customers
{
    public class GetCustomerRequest
    {
        public int CustomerId { get; set; }
    }

    public class GetCustomerResponse
    {
        public CustomerModel Customer { get; set; }
    }

    public class GetCustomerRequestValidator : AbstractValidator<GetCustomerRequest>
    {
        public GetCustomerRequestValidator()
        {
            RuleFor(request => request.CustomerId).NotEmpty();
        }
    }
}
