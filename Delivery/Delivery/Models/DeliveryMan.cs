using System.ComponentModel.DataAnnotations;

namespace Delivery.Models
{
    public class DeliveryMan
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
    }
}
