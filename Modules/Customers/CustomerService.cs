using Common;
using Common.Enums;
using Microsoft.EntityFrameworkCore;
using Qinchili.Db;
using Qinchili.Domain;

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
            var address = db.DeliveryAddresses.SingleOrDefault(address => address.CustomerId == request.CustomerId && address.Address == request.Address.Trim());
            if (address != null)
            {
                return ResponseHelper.Fail<AddDeliveryAddressResponse>(StatusCode.DeliveryAddressAlreadyExists);
            }

            address = new DeliveryAddress
            {
                CustomerId = request.CustomerId,
                Address = request.Address.Trim(),
                IsDefault = request.IsDefault,
                Timestamp = DateTime.Now
            };

            db.DeliveryAddresses.Add(address);
            db.SaveChanges();

            return ResponseHelper.Ok(new AddDeliveryAddressResponse { DeliveryAddress = CreateDeliveryAddressModel(address) });
        }

        public IResponse<CreateCustomerResponse> CreateCustomer(CreateCustomerRequest request)
        {
            var customer = db.Customers.SingleOrDefault(customer => customer.PhoneNumber == request.PhoneNumber);
            if (customer != null)
            {
                return ResponseHelper.Fail<CreateCustomerResponse>(StatusCode.CustomerWithTheSamePhoneNumberAlreadyExists);
            }

            customer = new Customer
            {
                Firstname = request.Firstname,
                Lastname = request.Lastname,
                Comment = request.Comment,
                FacebookUrl = request.FacebookUrl,
                PhoneNumber = request.PhoneNumber,
                Timestamp = DateTime.Now,
            };

            if (request.DeliveryAddresses != null && request.DeliveryAddresses.Any())
            {
                customer.DeliveryAddresses = new List<DeliveryAddress>();

                request.DeliveryAddresses.ForEach(address =>
                {
                    customer.DeliveryAddresses.Add(new DeliveryAddress 
                    {
                        Address = address.Address.Trim(),
                        IsDefault = address.IsDefault,
                        Timestamp = DateTime.Now
                    } );
                });
            }

            db.Customers.Add(customer);
            db.SaveChanges();

            return ResponseHelper.Ok(new CreateCustomerResponse { Customer = CreateCustomerModel(customer) });
        }

        public IResponse<EmptyResponse> DeleteDeliveryAddress(DeleteDeliveryAddressRequest request)
        {
            var address = db.DeliveryAddresses.SingleOrDefault(address => address.CustomerId == request.CustomerId && address.DeliveryAddressId == request.DeliveryAddressId);
            if (address == null)
            {
                return ResponseHelper.Fail<EmptyResponse>(StatusCode.DeliveryAddressNotFound);
            }

            address.DeleteTimestamp = DateTime.Now;
            db.SaveChanges();

            return ResponseHelper.Ok();
        }

        public IResponse<GetCustomerResponse> GetCustomer(GetCustomerRequest request)
        {
            var customer = db.Customers.AsNoTracking().SingleOrDefault(customer => customer.CustomerId == request.CustomerId);
            if (customer == null)
            {
                return ResponseHelper.Fail<GetCustomerResponse>(StatusCode.CustomerNotFound);
            }

            return ResponseHelper.Ok(new GetCustomerResponse { Customer = CreateCustomerModel(customer) });
        }

        public IResponse<GetCustomersResponse> GetCustomers()
        {
            return ResponseHelper.Ok(new GetCustomersResponse
            {
                Customers = db.Customers.AsNoTracking().Select(product => CreateCustomerModel(product))
            });
        }

        public IResponse<MakeDeliveryAddressDefaultResponse> MakeDeliveryAddressDefault(MakeDeliveryAddressDefaultRequest request)
        {
            var address = db.DeliveryAddresses.SingleOrDefault(address => address.CustomerId == request.CustomerId && address.DeliveryAddressId == request.DeliveryAddressId && address.DeleteTimestamp == null);
            if (address == null)
            {
                return ResponseHelper.Fail<MakeDeliveryAddressDefaultResponse>(StatusCode.DeliveryAddressNotFound);
            }

            address.IsDefault = request.IsDefault;
            db.SaveChanges();

            return ResponseHelper.Ok(new MakeDeliveryAddressDefaultResponse { DeliveryAddress = CreateDeliveryAddressModel(address) });
        }

        public IResponse<UpdateCustomerResponse> UpdateCustomer(UpdateCustomerRequest request)
        {
            var customer = db.Customers.AsNoTracking().SingleOrDefault(customer => customer.CustomerId == request.CustomerId);
            if (customer == null)
            {
                return ResponseHelper.Fail<UpdateCustomerResponse>(StatusCode.CustomerNotFound);
            }

            customer.Firstname = request.Firstname;
            customer.Lastname = request.Lastname;
            customer.FacebookUrl = request.FacebookUrl;
            customer.Comment = request.Comment;
            customer.PhoneNumber = request.PhoneNumber;

            return ResponseHelper.Ok(new UpdateCustomerResponse { Customer = CreateCustomerModel(customer) });
        }

        public IResponse<UpdateDeliveryAddressResponse> UpdateDeliveryAddress(UpdateDeliveryAddressRequest request)
        {
            var address = db.DeliveryAddresses.SingleOrDefault(address => address.CustomerId == request.CustomerId && address.DeliveryAddressId == request.DeliveryAddressId && address.DeleteTimestamp == null);
            if (address == null)
            {
                return ResponseHelper.Fail<UpdateDeliveryAddressResponse>(StatusCode.DeliveryAddressNotFound);
            }

            address.Address = request.Address;
            address.IsDefault = request.IsDefault;
            db.SaveChanges();

            return ResponseHelper.Ok(new UpdateDeliveryAddressResponse { DeliveryAddress = CreateDeliveryAddressModel(address) });
        }

        private CustomerModel CreateCustomerModel(Customer customer)
        {
            var result = new CustomerModel
            {
                CustomerId = customer.CustomerId,
                Firstname = customer.Firstname,
                Lastname = customer.Lastname,
                Comment = customer.Comment,
                FacebookUrl = customer.FacebookUrl,
                PhoneNumber = customer.PhoneNumber,
                Timestamp = customer.Timestamp
            };

            if (customer.DeliveryAddresses != null && customer.DeliveryAddresses.Any())
            {
                result.DeliveryAddresses = new List<DeliveryAddressModel>();

                customer.DeliveryAddresses.ToList().ForEach(address =>
                {
                    result.DeliveryAddresses.Add(new DeliveryAddressModel
                    {
                        CustomerDeliveryAddressId = address.DeliveryAddressId,
                        Address = address.Address,
                        IsDefault = address.IsDefault,
                        CustomerId = address.CustomerId,
                        Timestamp = address.Timestamp
                    });
                });
            }

            return result;
        }

        private DeliveryAddressModel CreateDeliveryAddressModel(DeliveryAddress address)
        {
            return new DeliveryAddressModel
            {
                CustomerDeliveryAddressId = address.DeliveryAddressId,
                Address = address.Address,
                IsDefault = address.IsDefault,
                CustomerId = address.CustomerId,
                Timestamp = address.Timestamp
            };
        }
    }
}
