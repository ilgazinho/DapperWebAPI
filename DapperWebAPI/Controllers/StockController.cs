using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperWebAPI.Models;
using DapperWebAPI.Service;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace DapperWebAPI.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/v1/[controller]")]
    public class StockController : Controller
    {
        private readonly IProductService _productBusiness;

        public StockController()
        {
            
        }

        // GET api/v1/products/{id}
        /// <summary>
        /// Get Product
        /// </summary>
        /// <param name="id"></param>
        /// <returns>return product</returns>
        [HttpGet("{id}")]
        public Stock Get(long id)
        {
            List<Stock> list = new List<Stock>();
            list.Add(new Stock() {
                Id=1,
                Colors = new List<Color>() {
                    new Color(){StockId=1,Name="Kırmızı"},
                   new Color(){StockId=1,Name="Beyaz"},
                   new Color(){StockId=1,Name="Lacivert"},
                },
                Name="Stok1"
            }
            );
            list.Add(new Stock()
            {
                Id = 2,
                Colors = new List<Color>() {
                   new Color(){StockId=2,Name="Beyaz"},
                   new Color(){StockId=2,Name="Lacivert"},
                },
                Name = "Stok2"
            }
          );
            return list.Where(x=>x.Id==id).FirstOrDefault();
            //   return await _productBusiness.GetAsync(id);
        }
        /// <summary>
        /// TEST Bütün ürünleri getirir
        /// </summary>
        /// <returns></returns>
        // GET api/v1/products
        [HttpGet]
        public List<Stock> GetList()
        {
            List<Stock> list = new List<Stock>();
            list.Add(new Stock()
            {
                Id = 1,
                Colors = new List<Color>() {
                    new Color(){StockId=1,Name="Kırmızı"},
                   new Color(){StockId=1,Name="Beyaz"},
                   new Color(){StockId=1,Name="Lacivert"},
                },
                Name = "Stok1"
            }
            );
            list.Add(new Stock()
            {
                Id = 2,
                Colors = new List<Color>() {
                   new Color(){StockId=2,Name="Beyaz"},
                   new Color(){StockId=2,Name="Lacivert"},
                },
                Name = "Stok2"
            }
          );
            return list;
        }

        // POST api/v1/products
        [ProducesResponseType(201)]
        [HttpPost]
        public async Task Post([FromBody] Stock productRequest)
        {
            //await _productBusiness.AddAsync(productRequest);
        }
    }

}
