﻿using Microsoft.EntityFrameworkCore;
using Qinchili.Domain;
using Qinchili.Model;

namespace Qinchili.Db
{
    public interface IQinchiliContext
    {
        DbSet<Product> Products { get; set; }
        
        DbSet<Customer> Customers { get; set; }

        int SaveChanges();
    }
}