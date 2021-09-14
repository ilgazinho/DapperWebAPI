using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DapperWebAPI.Service;
using DapperWebAPI.Contracts;
using DapperWebAPI.Repository;
using DapperWebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DapperWebAPI.Controllers
{
    [Authorize]
    [Route("api/v1/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductService _productBusiness;

        public ProductsController(IProductService productBusiness)
        {
            _productBusiness = productBusiness;
        }

        // GET api/v1/products/{id}
        /// <summary>
        /// Get Product
        /// </summary>
        /// <param name="id"></param>
        /// <returns>return product</returns>
        [HttpGet("{id}")]
        public async Task<ProductResponse> Get(long id)
        {
            return await _productBusiness.GetAsync(id);
        }
        /// <summary>
        /// TEST Bütün ürünleri getirir
        /// </summary>
        /// <returns></returns>
        // GET api/v1/products
        [HttpGet]
        public async Task<ProductResponse> Get()
        {
            return await _productBusiness.GetAllAsync();
        }

        // POST api/v1/products
        [ProducesResponseType(201)]
        [HttpPost]
        public async Task Post([FromBody]ProductRequest productRequest)
        {
            await _productBusiness.AddAsync(productRequest);
        }
    }
}