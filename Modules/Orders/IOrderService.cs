using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Orders
{
    public interface IOrderService
    {
        public IResponse<CreateOrderResponse> CreateOrder(CreateOrderRequest request);
    }
}
