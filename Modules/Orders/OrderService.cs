using Common;
using Qinchili.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Orders
{
    public class OrderService : IOrderService
    {
        public IResponse<CreateOrderResponse> CreateOrder(CreateOrderRequest request)
        {
            var order = new Order
            {
                CustomerId = request.CustomerId,
                DeliveryAddressId = request.DeliverAddressId,
            };

            throw new NotImplementedException();
        }
    }
}
