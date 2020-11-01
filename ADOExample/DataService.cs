using System;
using System.Collections.Generic;
using System.Linq;

namespace ADOExample
{
    public class DataService
    {



       public IList<Orders> GetOrders()

        {
            var ctx = new NorthWindContext();
           return ctx.Orders.ToList();
        }

        
    }
}

