using System;
using System.Collections.Generic;

namespace DapperWebAPI.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Color> Colors { get; set; }
    }

}

public class Color
{
    public int StockId { get; set; }
    public string Name { get; set; }
}
