using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BEInvitacionesOnline.Models
{
    public class TypesTemplate
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(200)]
        
        public string typeTemp { get; set; }
    }
}
