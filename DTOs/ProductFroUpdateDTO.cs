using System.ComponentModel.DataAnnotations;

namespace CoffeeMugTask.API.DTOs
{
    public class ProductFroUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Warrning: Name cannot be empty!")]
        [MaxLength(100, ErrorMessage = "Warrining: Name cannot contains more than 100 characters")]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}