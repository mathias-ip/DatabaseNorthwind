using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace ADOExample
{
    public class DataService
    {

        List<Category> _categories = new List<Category>
        {
            new Category{ Id = 1, Name = "Beverages", Description = "Soft drinks, coffees, teas, beers, and ales"},
            new Category{ Id = 2, Name = "Condiments", Description = "Sweet and savory sauces, relishes, spreads, and seasonings"},
            new Category{ Id = 3, Name = "Confections", Description = "Desserts, candies, and sweet breads"},
            new Category{ Id = 4, Name = "Dairy Products", Description = "Cheeses"},
            new Category{ Id = 5, Name = "Grains/Cereals", Description = "Breads, crackers, pasta, and cereal"},
            new Category{ Id = 6, Name = "Meat/Poultry", Description = "Prepared meats"},
            new Category{ Id = 7, Name = "Produce", Description = "Dried fruit and bean curd"},
            new Category{ Id = 8, Name = "Seafood", Description = "Seaweed and fish"}
        };

        public IList<Category> GetCategories() 
        {
            return _categories;
        } 

       public IList<Orders> GetOrders()

        {
            var ctx = new NorthWindContext();
           return ctx.Orders.ToList();
        }

        
    }
}

