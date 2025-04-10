using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace WhiskAwayAPI.Model
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Total { get; set; }

        [Required]
        public DateTime DateTimePurchased { get; set; }

        
    }
}
