using System.Collections.Generic;
using System.Threading.Tasks;
using CoffeeMugTask.API.Helpers;
using CoffeeMugTask.API.Models;

namespace CoffeeMugTask.API.Core
{
    public interface IProductRepository
    {
        Task<ProductModel> GetOneAsync(int productId);
        Task<PagedList<ProductModel>> GetAllAsync(ProductParams productParams);
        int CrateProduct(ProductModel product);
        void RemoveProduct(ProductModel product);
    }
}