using System;
namespace ADOExample
{
    public class Orders

        {
            public int Id { get; set; }

            public int orderdate { get; set; }

            public string shipname { get; set; }

            public string shipcity { get; set; }

            public override string ToString()
            {
                return $"Id = {Id}, orderdate = {orderdate}, shipname = {shipname}, shipcity ={shipcity}";
            }
        }
    }
