using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class SectionIntro : BaseEntity
    {
        [Key]
        public int ID { get; set; } 
        public string Image_URL { get; set; }    
        public string Title { get; set; }
        [Required]
        public string  Button_Title { get; set; }
        [Required]
        public string Destination_URL { get; set; }

    }
}
