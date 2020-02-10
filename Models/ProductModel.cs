namespace CoffeeMugTask.API.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Fluent API - Column type
        public decimal Price { get; set; }
    }
}