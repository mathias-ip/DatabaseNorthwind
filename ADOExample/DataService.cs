using System;
namespace ADOExample
{
    public class DataService
    {
        public void GetCategories()
        {



            var dataService = new DataService();


            using var ctx = new NorthWindContext();

            foreach (var product in ctx.Products.Include(x => x.Category))
            {
                Console.WriteLine(product);
            }



        }
    }
}
