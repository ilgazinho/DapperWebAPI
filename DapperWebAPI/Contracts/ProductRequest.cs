using System;
using System.Collections.Generic;

namespace DapperWebAPI.Contracts
{
    public class ProductRequest
    {
        public long CategoryId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}