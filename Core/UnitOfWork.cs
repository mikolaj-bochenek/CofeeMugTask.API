using System.Threading.Tasks;
using CoffeeMugTask.API.Data;

namespace CoffeeMugTask.API.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;

        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
            Products = new ProductRepository(_dataContext);
            
        }
        public IProductRepository Products { get; private set; }
        
        public async Task<bool> SaveAllAsync()
        {
            return await _dataContext.SaveChangesAsync() > 0;
        }
        
        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}