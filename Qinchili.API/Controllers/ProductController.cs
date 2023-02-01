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
        public IActionResult CreateProduct([FromBody] CreateProductRequest request)
        {
            return Ok(productService.CreateProduct(request));
        }

        [HttpPut("")]
        public IActionResult UpdateProduct([FromBody] UpdateProductRequest request)
        {
            return Ok(productService.UpdateProduct(request));
        }

        [HttpGet("")]
        public IActionResult GetProduct([FromQuery] GetProductRequest request)
        {
            return Ok(productService.GetProduct(request));
        }

        [HttpGet("all")]
        public IActionResult GetProducts()
        {
            return Ok(productService.GetProducts());
        }

        [HttpDelete("")]
        public IActionResult DeleteProduct([FromBody] DeleteProductRequest request)
        {
            return Ok(productService.DeleteProduct(request));
        }
    }
}
