using Common;
using Qinchili.Db;

namespace Modules.Customers
{
    public class CustomerService : ICustomerService
    {
        public readonly IQinchiliContext db;

        public CustomerService(IQinchiliContext db)
        {
            this.db = db;
        }

        public IResponse<AddDeliveryAddressResponse> AddDeliveryAddress(AddDeliveryAddressRequest request)
        {
            throw new NotImplementedException();
        }

        public IResponse<CreateCustomerResponse> CreateCustomer(CreateCustomerRequest request)
        {
            throw new NotImplementedException();
        }

        public IResponse<EmptyResponse> DeleteDeliveryAddress(DeleteDeliveryAddressRequest request)
        {
            throw new NotImplementedException();
        }

        public IResponse<GetCustomerResponse> GetCustomer(GetCustomerRequest request)
        {
            throw new NotImplementedException();
        }

        public IResponse<GetCustomersResponse> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public IResponse<MakeDeliveryAddressDefaultResponse> MakeDeliveryAddressDefault(MakeDeliveryAddressDefaultRequest request)
        {
            throw new NotImplementedException();
        }

        public IResponse<UpdateCustomerResponse> UpdateCustomer(UpdateCustomerRequest request)
        {
            throw new NotImplementedException();
        }

        public IResponse<UpdateDeliveryAddressResponse> UpdateDeliveryAddress(UpdateDeliveryAddressRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
