using FluentValidation;
using Modules.Customers;
using Modules.Orders;
using Modules.Products;

namespace Qinchili.API.Helpers
{
    public static class Extensions
    {
        public static void AddDIServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IOrderService, OrderService>();
        }

        public static void AddAbstractValidators(this IServiceCollection services)
        {
            services.AddScoped<IValidator<CreateProductRequest>, CreateProductRequestValidator>();
            services.AddScoped<IValidator<UpdateProductRequest>, UpdateProductRequestValidator>();
            services.AddScoped<IValidator<GetProductRequest>, GetProductRequestValidator>();
            services.AddScoped<IValidator<DeleteProductRequest>, DeleteProductRequestValidator>();

            services.AddScoped<IValidator<CreateCustomerRequest>, CreateCustomerRequestValidator>();
            services.AddScoped<IValidator<GetCustomerRequest>, GetCustomerRequestValidator>();
            services.AddScoped<IValidator<UpdateCustomerRequest>, UpdateCustomerRequestValidator>();

            services.AddScoped<IValidator<AddDeliveryAddressRequest>, AddDeliveryAddressRequestValidator>();
            services.AddScoped<IValidator<DeleteDeliveryAddressRequest>, DeleteDeliveryAddressRequestValidator>();
            services.AddScoped<IValidator<MakeDeliveryAddressDefaultRequest>, MakeDeliveryAddressDefaultRequestValidator>();

            services.AddScoped<IValidator<CreateCustomerRequest>, CreateCustomerRequestValidator>();
        }
    }
}
