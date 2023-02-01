using FluentValidation;

namespace Modules.Customers
{
    public class CreateCustomerRequest
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string PhoneNumber { get; set; }

        public string FacebookUrl { get; set; }

        public string Comment { get; set; }

        public List<DeliveryAddressModel> DeliveryAddresses { get; set; }
    }

    public class CreateCustomerResponse
    {
        public CustomerModel Customer { get; set; }
    }

    public class CreateCustomerRequestValidator : AbstractValidator<CreateCustomerRequest>
    {
        public CreateCustomerRequestValidator()
        {
            RuleFor(request => request.Firstname).NotEmpty();
        }
    }
}
