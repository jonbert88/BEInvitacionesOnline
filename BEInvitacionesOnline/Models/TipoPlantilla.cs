using System.ComponentModel.DataAnnotations;

namespace BEInvitacionesOnline.Models
{
    public class TipoPlantilla
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(200)]
        public string tipoPlantilla { get; set; }
    }
}
