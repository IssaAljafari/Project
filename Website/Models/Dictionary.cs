using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Dictionary : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(20)]
        public string Code { get; set; }
        public int LanguageID { get; set; }
        [Required]
        public string Text { get; set; }
    }
}
