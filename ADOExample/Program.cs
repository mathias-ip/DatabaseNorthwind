﻿
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ADOExample
{
    class Program
    {
        static void Main(string[] args)
        {

            var dataService = new DataService();
            foreach (var elem in dataService.GetOrders())
            {
                Console.WriteLine(elem);

            }









           /* var ctx = new NorthWindContext();
            var orders = ctx.Orders.ToList();
            var catagory = ctx.Categories.ToList();*/





            //using var ctx = new NorthWindContext();

            //foreach (var product in ctx.Products.Include(x => x.Category))
            //{
            //    Console.WriteLine(product);
            //}


            //var cat = ctx.Categories.Find(9);

            //ctx.Categories.Remove(cat);

            ////cat.Name = "UpdateTest";
            ////cat.Description = "fdsjfsldkjfsdlkf";

            ////var maxId = ctx.Categories.Max(x => x.Id);

            ////ctx.Categories.Add(new Category {Id = maxId + 1, Name = "Testing"});

            //ctx.SaveChanges();

            //foreach (var category in ctx.Categories)
            //{
            //    Console.WriteLine(category);
            //}
        }
    }
}
