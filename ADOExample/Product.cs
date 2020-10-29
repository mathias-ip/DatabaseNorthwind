using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOExample
{
    public class Product
    {
        public int Id { get; set; }

        public int date { get; set; }

        public string shipname { get; set; }

        public string shipcity { get; set; }

        public override string ToString()
        {
            return $"Id = {Id}, date = {date}, shipname = {shipname}, shipcity ={shipcity}";
        }
    }
}
