using CoffeeMugTask.API.DTOs;
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
            base.OnModelCreating(modelBuilder);

            // Fluent API
            
            modelBuilder.Entity<ProductModel>()
                        .Property(p => p.Price)
                        .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ProductForCreateDTO>()
                        .HasNoKey();
                        
            modelBuilder.Entity<ProductForCreateDTO>()
                        .Property(p => p.Name)
                        .IsRequired()
                        .HasMaxLength(100);

            modelBuilder.Entity<ProductForCreateDTO>()
                        .Property(p => p.Price)
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");
        }
    }
}