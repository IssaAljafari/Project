using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class SectionLatestNewList : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string ImageURL { get; set; }
        [Required, MaxLength(100)]
        public string Title { get; set; }
        [Required]
        public string DestinationURL { get; set; }
    }
}
