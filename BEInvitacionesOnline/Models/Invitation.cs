using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BEInvitacionesOnline.Models
{
    public class Invitation
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int idUser { get; set; }

        [ForeignKey("idUser")]
        public User? User { get; set; }

        
        public int idPayment { get; set; }

        [ForeignKey("idPayment")]
        public Payment? Payment { get; set; }

        public int idTemplate { get; set; }

        [ForeignKey("idTemplate")]
        public Template? Template { get; set; }


        public int idInformation { get; set; }

        [ForeignKey("idInformation")]
        public Information? Information { get; set; }
    }
}
