using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using DapperWebAPI.Models;
using Dapper;
using System.Linq;

namespace DapperWebAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly string _connectionString;
        private  IDbConnection _connection { get { return new SqlConnection(_connectionString); }}

        private List<Product> productList = new List<Product>();
        public ProductRepository()
        {
            // TODO: It will be refactored...
            ///_connectionString = ""//

            productList.Add(new Product() {
                Id=1,
                CategoryId=1,
                CreatedDate=DateTime.Now,
                Description="test1",
                Name="test1",
                Price=100

            });
            productList.Add(new Product()
            {
                Id = 2,
                CategoryId = 2,
                CreatedDate = DateTime.Now,
                Description = "test2",
                Name = "test2",
                Price = 200

            });
            productList.Add(new Product()
            {
                Id = 3,
                CategoryId = 3,
                CreatedDate = DateTime.Now,
                Description = "test3",
                Name = "test3",
                Price = 300

            });
        }

        public async Task<Product> GetAsync(long id)
        {
            /*
            using (IDbConnection dbConnection = _connection)
            {
                string query = @"SELECT [Id] ,[CategoryId]
                                ,[Name]3
                                ,[Description]
                                ,[Price]
                                ,[CreatedDate]
                                FROM [dbo].[Products]
                                WHERE [Id] = @Id";

                var product = await dbConnection.QueryFirstOrDefaultAsync<Product>(query, new{ @Id = id });

                return product;
            }*/
            return productList.Where(x=>x.Id==id).FirstOrDefault();

        }
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            //TODO: Paging...
            /*  using (IDbConnection dbConnection = _connection)
              {
                  string query = @"SELECT [Id] ,[CategoryId]
                                  ,[Name]
                                  ,[Description]
                                  ,[Price]
                                  ,[CreatedDate]
                                  FROM [dbo].[Products]";

                  var product = await dbConnection.QueryAsync<Product>(query);

                  return product;
              }*/
            return productList;
        }

        public async Task AddAsync(Product product)
        {
            /*   using (IDbConnection dbConnection = _connection)
               {
                   string query = @"INSERT INTO [dbo].[Products] (                                
                                   [CategoryId],
                                   [Name],
                                   [Description],
                                   [Price]) VALUES (
                                   @CategoryId,
                                   @Name,
                                   @Description,
                                   @Price)";

                   await dbConnection.ExecuteAsync(query, product);
               }*/
            
        }
    }
}