using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class SectionCinemaLibraryFooter : BaseEntity
    {
        [Key]
        public int ID { get; set; }
        public string WorldCinemaTitle { get; set; }
        public string ArabCinemaTitle { get; set; }
        

    }
}
