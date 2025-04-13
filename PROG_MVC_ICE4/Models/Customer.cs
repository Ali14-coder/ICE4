using System.ComponentModel.DataAnnotations;

namespace PROG_MVC_ICE4.Models
{
    public class Customer
    {
        [Key]
        [Required]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [StringLength(150)]
        public string Surname { get; set; }

        [Required]
        [StringLength(150)]
        public string Email { get; set; }

        [Required]
        [StringLength(150)]
        public string Password { get; set; }
    }
}
