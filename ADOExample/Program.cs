using System;
using Npgsql;

namespace ADOExample
{

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        class Products
        {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int SupplierId { get; set; }
        //public int CategoryId { get; set; }
        public string Quantityperunit { get; set; }
        public int Unitprice { get; set; }
        public int Unitsinstock { get; set; }
        }



        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
                "host=localhost;db=Northwind;uid=postgres;pwd=";
            using var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            using var cmd = new NpgsqlCommand();

            cmd.Connection = conn;
            cmd.CommandText = "select categoryid, categoryname from categories";

            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var category = new Category
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1)
                };

                Console.WriteLine(category);

                //Console.WriteLine($"Id={reader.GetInt32(0)}, Name={reader.GetString(1)}");
            }
        }
    }
}
