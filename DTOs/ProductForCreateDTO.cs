using System.ComponentModel.DataAnnotations;

namespace CoffeeMugTask.API.DTOs
{
    public class ProductForCreateDTO
    {
        [Required(ErrorMessage = "Warrning: Name cannot be empty!")]
        [MaxLength(100, ErrorMessage = "Warrining: Name cannot contains more than 100 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Warrning: Price cannot be empty!")]
        public decimal Price { get; set; }
    }
}