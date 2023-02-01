using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modules.Customers;
using Modules.Customers;

namespace Qinchili.API.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpPost("")]
        public IActionResult CreateCustomer([FromBody] CreateCustomerRequest request)
        {
            return Ok(customerService.CreateCustomer(request));
        }

        [HttpPut("")]
        public IActionResult UpdateCustomer([FromBody] UpdateCustomerRequest request)
        {
            return Ok(customerService.UpdateCustomer(request));
        }

        [HttpGet("")]
        public IActionResult GetCustomer([FromQuery] GetCustomerRequest request)
        {
            return Ok(customerService.GetCustomer(request));
        }

        [HttpGet("all")]
        public IActionResult GetCustomers()
        {
            return Ok(customerService.GetCustomers());
        }

        [HttpPost("deliveryaddress")]
        public IActionResult AddDeliveryAddress([FromBody] AddDeliveryAddressRequest request)
        {
            return Ok(customerService.AddDeliveryAddress(request));
        }

        [HttpPut("deliveryaddress")]
        public IActionResult UpdateDeliveryAddress([FromBody] UpdateDeliveryAddressRequest request)
        {
            return Ok(customerService.UpdateDeliveryAddress(request));
        }

        [HttpPatch("deliveryaddress/default")]
        public IActionResult MakeDeliveryAddressDefault([FromBody] MakeDeliveryAddressDefaultRequest request)
        {
            return Ok(customerService.MakeDeliveryAddressDefault(request));
        }

        [HttpDelete("deliveryaddress")]
        public IActionResult DeleteDeliveryAddress([FromBody] DeleteDeliveryAddressRequest request)
        {
            return Ok(customerService.DeleteDeliveryAddress(request));
        }
    }
}
