using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class SectionVisiblity : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        [Required,MaxLength(100)]
        public string SectionName { get; set; } 
        public Boolean IsVisible { get; set; }    
    }
}
