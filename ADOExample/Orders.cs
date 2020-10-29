using System;
namespace ADOExample
{
    //assignment 2
    public class Orders

        {
            public int Id { get; set; }

            public DateTime orderdate { get; set; }

            public string shipname { get; set; }

            public string shipcity { get; set; }

            public override string ToString()
            {
                return $"Id = {Id}, orderdate = {orderdate}, shipname = {shipname}, shipcity ={shipcity}";
            }
        }
    }
