using System.ComponentModel.DataAnnotations;

namespace BEInvitacionesOnline.Models
{
    public class Payment
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string  nameCard { get; set; }

        [Required]
        public string numberCard { get; set; }

        [Required]
        [MaxLength(5)]
        public string expireDate{ get; set; }
        [Required]
        [MaxLength(3)]
        public string cvv { get; set; }

    }
}
