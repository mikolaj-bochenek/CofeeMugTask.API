using CoffeeMugTask.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeMugTask.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<ProductModel> Products { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API
        }
    }
}