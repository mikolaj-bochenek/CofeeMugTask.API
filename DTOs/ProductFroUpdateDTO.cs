using System.ComponentModel.DataAnnotations;

namespace CoffeeMugTask.API.DTOs
{
    public class ProductFroUpdateDTO
    {
        [Required(ErrorMessage = "Warrning: Id cannot be empty!")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Warrning: Name cannot be empty!")]
        [MaxLength(100, ErrorMessage = "Warrining: Name cannot contains more than 100 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Warrning: Price cannot be empty!")]
        public decimal Price { get; set; }
    }
}