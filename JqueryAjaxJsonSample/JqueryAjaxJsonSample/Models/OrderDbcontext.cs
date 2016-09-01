using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JqueryAjaxJsonSample.Models
{
    public class OrderDbcontext:DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public DbSet<Item> Items { get; set; }

    }
}