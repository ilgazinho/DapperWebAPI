using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DapperWebAPI.Models;

namespace DapperWebAPI.Repository
{
    public interface IProductRepository
    {
        Task<Product> GetAsync(long id);
        Task<IEnumerable<Product>> GetAllAsync();
        Task AddAsync(Product product);
    }
}