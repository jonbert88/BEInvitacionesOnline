using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BEInvitacionesOnline.Models
{
    public class User
    {
        
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Nada de anónimos. ¡Aquí todo el mundo tiene un nombre!")]
        [MaxLength(150)]
        public string email{ get; set; }
        
        [Required]
        [MaxLength(150)]
        public string userName { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public int idProfile { get; set; }

        [ForeignKey("idProfile")]
        public Profile? Profile { get; set; }

    }
}
