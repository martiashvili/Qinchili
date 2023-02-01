using FluentValidation;

namespace Modules.Customers
{
    public class UpdateCustomerRequest
    {
        public int CustomerId { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string PhoneNumber { get; set; }

        public string FacebookUrl { get; set; }

        public string Comment { get; set; }
    }

    public class UpdateCustomerResponse
    {
        public CustomerModel Customer { get; set; }
    }

    public class UpdateCustomerRequestValidator : AbstractValidator<UpdateCustomerRequest>
    {
        public UpdateCustomerRequestValidator()
        {
            RuleFor(request => request.Firstname).NotEmpty();
        }
    }
}
