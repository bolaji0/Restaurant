using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class RestaurantMenus
    {
        [Key]
        public int MenuId { get; set; }
        [Required]
        public string? MenuName { get; set; }

        public int NumberOfMenu { get; set; }

    }
}
