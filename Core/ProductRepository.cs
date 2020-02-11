using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeMugTask.API.Data;
using CoffeeMugTask.API.Helpers;
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

        public async Task<PagedList<ProductModel>> GetAllParametedAsync(ProductParams productParams)
        {
            var products = _dataContext.Products.OrderBy(p => p.Id);

            if (!string.IsNullOrEmpty(productParams.OrderBy))
            {
                switch(productParams.OrderBy)
                {
                    case "Alphabetically":
                        products = products.OrderBy(p => p.Name);
                        break;
                    
                    case "Cheap":
                        products = products.OrderBy(p => p.Price);
                        break;
                    
                    case "Expensive":
                        products = products.OrderByDescending(p => p.Price);
                        break;
                    
                    default:
                        products = products.OrderBy(p => p.Id);
                        break;
                }
            }
            
            return await PagedList<ProductModel>.CreateListAsync(products, productParams.PageSize, productParams.PageNumber);
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