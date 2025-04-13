using System.ComponentModel.DataAnnotations;

namespace PROG_MVC_ICE4.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public String ProductName { get; set; }

        [Required]

        public double Price { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }
    }
}
