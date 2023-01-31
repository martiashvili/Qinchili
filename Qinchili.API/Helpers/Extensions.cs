using Modules.Products;

namespace Qinchili.API.Helpers
{
    public static class Extensions
    {
        public static void AddDIServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
        }
    }
}
