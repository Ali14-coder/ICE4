using System.ComponentModel.DataAnnotations;

namespace PROG_MVC_ICE4.Models
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
