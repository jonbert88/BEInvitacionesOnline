using System.ComponentModel.DataAnnotations;

namespace BEInvitacionesOnline.Models
{
    public class Information
    {
        [Key]   
        
        public int Id { get; set; }
        
        public string narrativeOne { get; set; }
        
        public string narrativeTwo { get; set; }
        public string narrativeThree { get; set; }
        public string narrativeFour { get; set; }
        public string narrativeFive { get; set; }
        public string narrativeSix { get; set; }
        public string narrativeSeven { get; set; }
        public string narrativeEight { get; set; }
        [MaxLength(150)]
        public string nameOne { get; set; }

        [MaxLength(150)]
        public string nameTwo { get; set; }

        [MaxLength(150)]
        public string nameThree { get; set; }
        [MaxLength(150)]
        public string nameFour { get; set; }
        [MaxLength(150)]
        public string nameFive { get; set; }
        [MaxLength(150)]
        public string nameSix { get; set; }
        [MaxLength(150)]
        public string nameSeven { get; set; }
        [MaxLength(150)]
        public string nameEight { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dateEvent { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dateEventTwo { get; set; }
        
        public TimeSpan startTime { get; set; }
        public TimeSpan endTime { get; set; }

        public TimeSpan stratTimeTwo { get; set; }
        public TimeSpan endTimeTwo { get; set; }
        public string address { get; set; }
        public string addressTwo { get; set; }
        public string addressThree { get; set; }
        public string urlImageOne { get; set; }
        public string urlImageTwo { get; set; }
        public string urlImageThree { get; set; }
        public string urlImageFour { get; set;}
        public string urlImageFive { get; set;}
        public string urlImageSix { get; set; }
        public string urlImageSeven { get;set;}
        public string urlImageEight { get;set;}

    }
}
