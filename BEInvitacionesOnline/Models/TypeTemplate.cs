using System.ComponentModel.DataAnnotations;

namespace BEInvitacionesOnline.Models
{
    public class TypeTemplate
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(200)]
        public string typeTemplate { get; set; }
    }
}
