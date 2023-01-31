using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Products
{
    public interface IProductService
    {
        public IEnumerable<int> GetProduct();
    }
}
