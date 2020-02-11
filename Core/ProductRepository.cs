using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeMugTask.API.Data;
using CoffeeMugTask.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeMugTask.API.Core
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _dataContext;
        public ProductRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public int CrateProduct(ProductModel product)
        {
            _dataContext.Products.Add(product);
            return product.Id;
        }

        public async Task<IEnumerable<ProductModel>> GetAllAsync()
        {
            return await _dataContext.Products.OrderByDescending(p => p.Price).ToListAsync();
        }

        public async Task<ProductModel> GetOneAsync(int productId)
        {
            return await _dataContext.Products.Where(p => p.Id == productId).FirstOrDefaultAsync();
        }

        public void RemoveProduct(ProductModel product)
        {
            _dataContext.Products.Remove(product);
        }
    }
}