using System.ComponentModel.DataAnnotations;

namespace CoffeeMugTask.API.DTOs
{
    public class ProductFroUpdateDTO
    {
        [Required(ErrorMessage = "BadRequest: Id cannot be empty!")]
        public int Id { get; set; }
        [Required(ErrorMessage = "BadRequest: Name cannot be empty!")]
        [MaxLength(100, ErrorMessage = "BadRequest: Name cannot contains more than 100 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "BadRequest: Price cannot be empty!")]
        public decimal Price { get; set; }
    }
}