using Common;

namespace Modules.Customers
{
    public interface ICustomerService
    {
        public IResponse<CreateCustomerResponse> CreateCustomer(CreateCustomerRequest request);

        public IResponse<UpdateCustomerResponse> UpdateCustomer(UpdateCustomerRequest request);
     
        public IResponse<GetCustomerResponse> GetCustomer(GetCustomerRequest request);

        public IResponse<GetCustomersResponse> GetCustomers();

        public IResponse<AddDeliveryAddressResponse> AddDeliveryAddress(AddDeliveryAddressRequest request);

        public IResponse<UpdateDeliveryAddressResponse> UpdateDeliveryAddress(UpdateDeliveryAddressRequest request);

        public IResponse<EmptyResponse> DeleteDeliveryAddress(DeleteDeliveryAddressRequest request);

        public IResponse<MakeDeliveryAddressDefaultResponse> MakeDeliveryAddressDefault(MakeDeliveryAddressDefaultRequest request);
    }
}
