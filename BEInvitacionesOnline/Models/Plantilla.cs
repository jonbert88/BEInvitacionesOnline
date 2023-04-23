using System.ComponentModel.DataAnnotations;

namespace BEInvitacionesOnline.Models
{
    public class Class
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nombrePlantilla { get; set; }
        [Required]
        public string  divHeader { get; set; }

    }
}
