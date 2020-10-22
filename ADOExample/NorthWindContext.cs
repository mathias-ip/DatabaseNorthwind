using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ADOExample
{
    public class NorthWindContext : DbContext
    {
        public static readonly ILoggerFactory MyLoggerFactory
            = LoggerFactory.Create(builder => { builder.AddConsole(); });

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Orders> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(MyLoggerFactory);
            optionsBuilder.UseNpgsql("host=localhost;db=Northwind;uid=postgres;pwd=191191Ippe");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToTable("categories");
            modelBuilder.Entity<Category>().Property(x => x.Id).HasColumnName("categoryid");
            modelBuilder.Entity<Category>().Property(x => x.Name).HasColumnName("categoryname");
            modelBuilder.Entity<Category>().Property(x => x.Description).HasColumnName("description");

            modelBuilder.Entity<Product>().ToTable("products");
            modelBuilder.Entity<Product>().Property(x => x.Id).HasColumnName("productid");
            modelBuilder.Entity<Product>().Property(x => x.Name).HasColumnName("productname");
           // modelBuilder.Entity<Product>().Property(x => x.CategoryId).HasColumnName("categoryid");

            modelBuilder.Entity<Orders>().ToTable("orders");
            modelBuilder.Entity<Orders>().Property(x => x.Id).HasColumnName("orderid");
           // modelBuilder.Entity<Orders>().Property(x => x.date).HasColumnName("orderdate");
            //modelBuilder.Entity<Category>().Property(x => x.Description).HasColumnName("description");
        }
    }

    
}
