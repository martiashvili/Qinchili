using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modules.Products;

namespace Qinchili.API.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [Route("")]
        [HttpGet]
        public bool GetProduct()
        {
            productService.GetProduct();

            return true;
        }
    }
}
