using System.Collections.Generic;
using System.Threading.Tasks;
using CoffeeMugTask.API.Data;
using CoffeeMugTask.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeMugTask.API.Core
{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository(DataContext dataContext) : base(dataContext) {}
        public int CrateProduct(ProductModel product)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ProductModel>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<ProductModel> GetOneAsync(int productId)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveProduct(ProductModel product)
        {
            throw new System.NotImplementedException();
        }
    }
}