using System.ComponentModel.DataAnnotations;

namespace BEInvitacionesOnline.Models
{
    public class Profile
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(120)]
        [Display(Name = "Profile")]
        public string perfil { get; set; }

    }
}
