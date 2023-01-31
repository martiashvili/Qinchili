using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.Products
{
    public class ProductModel
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string? Comment { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int CardsCount { get; set; }

        public long Price { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
