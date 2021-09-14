using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DapperWebAPI.Contracts;
using DapperWebAPI.Models;

namespace DapperWebAPI.Service
{
    public interface IProductService
    {
        Task<ProductResponse> GetAsync(long id);
        Task<ProductResponse> GetAllAsync();
        Task AddAsync(ProductRequest productRequest);
    }
}