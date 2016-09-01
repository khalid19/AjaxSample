using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JqueryAjaxJsonSample.Models.ViewModel
{
    public class OrderViewModel
    {
        public Order Order { get; set; }

        public List<Order> Orders { get; set; }


        public OrderViewModel()
        {
            Order=new Order();

            Orders=new List<Order>();
        }

    }
}