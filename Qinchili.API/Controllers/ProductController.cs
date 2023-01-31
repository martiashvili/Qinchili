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

        [HttpPost("")]
        public IActionResult CreateProduct(CreateProductRequest request)
        {
            return Ok(productService.CreateProduct(request));
        }
    }
}
