using System.Collections.Generic;
using System.Threading.Tasks;
using CoffeeMugTask.API.Models;

namespace CoffeeMugTask.API.Core
{
    public interface IProductRepository
    {
        Task<ProductModel> GetOneAsync(int productId);
        Task<IEnumerable<ProductModel>> GetAllAsync();
        int CrateProduct(ProductModel product);
        void RemoveProduct(ProductModel product);
    }
}