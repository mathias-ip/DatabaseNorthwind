using System;
using System.Collections.Generic;

namespace ADOExample
{
    public class DataService
    {



        public IList<Orders> GetOrders()

        {
            using var ctx = new NorthWindContext();
            return ctx.Categories.ToList();
        }


    }
}

