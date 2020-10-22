﻿using System;
namespace ADOExample
{
    public class Orders
      
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, Category = {Category.Name}";
        }
    }
}
