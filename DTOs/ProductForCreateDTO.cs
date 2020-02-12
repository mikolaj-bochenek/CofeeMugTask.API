using System.ComponentModel.DataAnnotations;

namespace CoffeeMugTask.API.DTOs
{
    public class ProductForCreateDTO
    {
        [Required(ErrorMessage = "BadRequest: Name cannot be empty!")]
        [MaxLength(100, ErrorMessage = "BadRequest: Name cannot contains more than 100 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "BadRequest: Price cannot be empty!")]
        public decimal Price { get; set; }
    }
}