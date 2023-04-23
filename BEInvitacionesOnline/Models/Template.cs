using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BEInvitacionesOnline.Models
{
    public class Template
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int idTypeTemplate { get; set; }

        [ForeignKey("idTypeTemplate")]
        public TypeTemplate? TypeTemplate { get; set; }

        [Required]
        public string nombrePlantilla { get; set; }
        
        public string  divHeader { get; set; }

        public string divContentCero { get; set; }

        public string divContentOne { get; set; }
        public string divContentTwo { get; set; }

        public string divContentThree { get; set; }

        public string divContentFour { get; set; }
        public string divContentFive { get; set; }
        public string divContentSix { get; set; }
        public string divContentSeven { get;set; }
        public string divContentEight{ get; set; }
        public string divContentFooter { get; set;}

    }
}
