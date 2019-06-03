using System.ComponentModel.DataAnnotations;

namespace Delivery.Models
{
    public class SingleOrder
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        [Required]
        public Recipe Recipe { get; set; }
        public int RestaurantId { get; set; }
        [Required]
        public Restaurant Restaurant { get; set; }
    }
}
