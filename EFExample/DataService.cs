using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFExample
{
    public class DataService
    {

        public IList<Category> GetCategories()
        {
            using var ctx = new NorthWindContext();
            return ctx.Categories.ToList();
        }


        public IList<Product> GetProducts()
        {
            using var ctx = new NorthWindContext();
            return ctx.Products
                .Include(x => x.Category)
                .ToList();
        }

    }
}
