using Microsoft.EntityFrameworkCore;
using Qinchili.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qinchili.Db
{
    public interface IQinchiliContext
    {
        DbSet<Product> Products { get; set; }
    }
}
