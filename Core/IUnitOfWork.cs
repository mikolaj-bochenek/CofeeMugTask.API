using System;
using System.Threading.Tasks;

namespace CoffeeMugTask.API.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        Task<bool> SaveAllAsync();
    }
}