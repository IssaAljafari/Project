using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Language : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public Boolean IsRTL { get; set; }
        public string Short_Name { get; set; }
        public Boolean IsDefault { get; set; }
        public string Image { get; set; }   

    }
}
