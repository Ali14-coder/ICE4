using System.ComponentModel.DataAnnotations;

namespace WhiskAwayAPI.Model
{
    public class Admin
    {
        [Key]

        [Required]
        public int AdminId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Surname { get; set; }
        [Required]
        [StringLength(150)]
        public string Email { get; set; }

        [Required]
        [StringLength(150)]
        public string Password { get; set; }
    }
}
