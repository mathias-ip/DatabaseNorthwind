using System;
using System.Collections.Generic;
using System.Linq;

namespace ADOExample
{
    public class DataService
    {



        public IList<Category> GetCategories()

        {
            var ctx = new NorthWindContext();
            return ctx.Categories.ToList();
        }


    }
}

